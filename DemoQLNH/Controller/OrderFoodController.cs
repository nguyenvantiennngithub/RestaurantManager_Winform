using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    class OrderFoodController
    {
        ComboBox cbFood;
        ComboBox cbFoodCategory;
        ListView listViewFoodOrder;
        NumericUpDown numUDCountFood;

        public OrderFoodController(ListView listViewFoodOrder, ComboBox cbFoodCategory, ComboBox cbFood, NumericUpDown numUDCountFood)
        {
            this.cbFood = cbFood;
            this.cbFoodCategory = cbFoodCategory;
            this.listViewFoodOrder = listViewFoodOrder;
            this.numUDCountFood = numUDCountFood;
        }

        public OrderFoodController(ListView listViewFoodOrder)
        {
            this.listViewFoodOrder = listViewFoodOrder;
        }



        public void loadFoodWhenSelectFoodCategory()
        {
            cbFood.DataBindings.Clear();
            cbFood.DisplayMember = "displayName";
            cbFood.DataBindings.Add("DataSource", cbFoodCategory.SelectedValue, "ListFood");
        }
        //cbFoodCategory
        //listViewFoodOrder
        //cbFood
        //numUDCountF
        public void loadCategoryFood()
        {
            List<FoodGroupByDTO> listFoodGroupBy = FoodDAO.Instance.getListFoodGroupByDisplayNameCategory();
            List<Food> listFood = FoodDAO.Instance.getListFood();

            listFoodGroupBy.Insert(0, new FoodGroupByDTO("Tất cả món ăn", listFood));

            cbFoodCategory.DataSource = listFoodGroupBy;
            cbFoodCategory.DisplayMember = "Key";
        }
        //List<ListFoodOrder> listFoodOrder = SqlHealper.Instance.getListFoodOrderByIdTable(idTable);
        public void loadListFood(List<ListFoodOrderDTO> listFoodOrder, int idTable)//đổi panel bằng idTalbe
        {
            int i = 0;
            string displayNameAreaTable = TableDAO.Instance.getAreaTable(idTable);

            listViewFoodOrder.Items.Clear();
            foreach (ListFoodOrderDTO foodOrder in listFoodOrder)
            {

                int price = (displayNameAreaTable == "Khu vip") ? foodOrder.PriceVip : foodOrder.PriceNormal;
                ListViewItem listViewItem = new ListViewItem(i.ToString());

                int totalPrice = foodOrder.Count * price;
                listViewItem.SubItems.Add(foodOrder.DisplayNameFood);
                listViewItem.SubItems.Add(price.ToString());
                listViewItem.SubItems.Add(foodOrder.Count.ToString());
                listViewItem.SubItems.Add(totalPrice.ToString());
                listViewFoodOrder.Items.Add(listViewItem);
                i++;
            }
        }
        public void cbFoodCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            cbFood.DataBindings.Clear();
            cbFood.DisplayMember = "displayName";
            cbFood.DataBindings.Add("DataSource", cbFoodCategory.SelectedValue, "ListFood");
        }

       
        public int checkFoodOrdered(string nameFoodOrder)
        {
            foreach (ListViewItem listItem in listViewFoodOrder.Items)
            {
                if (listItem.SubItems[1].Text == nameFoodOrder) return listItem.Index;//index = 1 la displayNameFood
            }
            return -1;
        }
        public bool handleOrderWhenFoodExist(Food food, int indexOfFood, int countFood, bool isSaveChangeDB, int idTable)
        {
            int countOfFoodInOrder = int.Parse(listViewFoodOrder.Items[indexOfFood].SubItems[3].Text);
            int totalCountFoodOrder = countOfFoodInOrder + countFood;//index = 3 la count of food

            if (totalCountFoodOrder < 0)
            {
                MessageBox.Show("Bớt món ăn hơi lố, món ăn đã order không đủ để bớt kiểu đó");
                return false;
            }
            else if (totalCountFoodOrder == 0)
            {
                listViewFoodOrder.Items.RemoveAt(indexOfFood);
                if (isSaveChangeDB) BillDetailDAO.Instance.removeRowBillDetail(idTable, food.displayName);

                return true;
            }
            else
            {
                int priceOfFood = int.Parse(listViewFoodOrder.Items[indexOfFood].SubItems[2].Text);//index = 2 la price of food
                listViewFoodOrder.Items[indexOfFood].SubItems[3].Text = totalCountFoodOrder.ToString();//index = 3 la count of food
                listViewFoodOrder.Items[indexOfFood].SubItems[4].Text = (totalCountFoodOrder * priceOfFood).ToString();
                if (isSaveChangeDB) BillDetailDAO.Instance.changeCountFoodOrderBillDetail(idTable, food.displayName, totalCountFoodOrder);
                return true;
            }
        }

        public bool handleOrderWhenFoodNotExist(Food food, int countFood, bool isSaveChangeDB, int idTable)
        {
            if (countFood > 0)
            {
                string displayNameAreTable = TableDAO.Instance.getAreaTable(idTable);

                int price = displayNameAreTable == "Khu vip" ? food.priceVip : food.priceNormal;
                string maxIndexOfListViewOrderFood = listViewFoodOrder.Items.Count.ToString();
                ListViewItem listViewItem = new ListViewItem(maxIndexOfListViewOrderFood);
                listViewItem.SubItems.Add(food.displayName);
                listViewItem.SubItems.Add(price.ToString());
                listViewItem.SubItems.Add(countFood.ToString());
                listViewItem.SubItems.Add((price * countFood).ToString());
                listViewFoodOrder.Items.Add(listViewItem);
                if (isSaveChangeDB) BillDetailDAO.Instance.addRowBillDetail(idTable, food.displayName, countFood);
                return true;
            }
            else
            {
                MessageBox.Show("Đã có trong list order đâu mà đòi bớt ra???");
                return false;
            }
        }

        public bool handleOrderFood(bool isSaveChangeDB, int idTable)
        {
            int countFood = (int)numUDCountFood.Value;
            object temp = cbFood.SelectedValue;
            Food food = temp as Food;

            if (countFood != 0)
            {
                int indexOfFood = checkFoodOrdered(food.displayName);
                if (indexOfFood >= 0)//Food này đã có trong order list
                {
                    return handleOrderWhenFoodExist(food, indexOfFood, countFood, isSaveChangeDB, idTable);
                }
                else
                {
                    return handleOrderWhenFoodNotExist(food, countFood, isSaveChangeDB, idTable);
                }
            }
            else
            {
                MessageBox.Show("Thêm số lượng là 0 là saoo????????", "Thông báo thêm thức ăn không được");
                return false;
            }
        }
        public int updateTotalPrice()
        {
            int totalPrice = 0;
            foreach (ListViewItem item in listViewFoodOrder.Items)
            {
                totalPrice += int.Parse(item.SubItems[4].Text);
            }
            return totalPrice;
        }
    }
}
