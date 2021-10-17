using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    public partial class fEditBookingTable : Form
    {
        private BookingTableDTO data;//toàn bộ về đặt bàn trừ món ăn
        OrderFoodController orderFood;
        SortListViewController sortListViewOrder;
        LoadDataBookingController loadDataBooking;
        public event EventHandler<EventArgs> refesh;

        public fEditBookingTable(BookingTableDTO data)
        {
            InitializeComponent();
            this.data = data;
            sortListViewOrder = new SortListViewController(listViewFoodOrder);
            loadDataBooking = new LoadDataBookingController(data, txbIdCustomer, txbNameCustomer, txbPhoneCustomer, 
                txbAddressCustomer, rdoMaleCustomer, rdoFemaleCustomer, cbTableBooking, dateTimeBooking, 
                txbCountBooking, txbDepositBooking, txbNoteBooking);
            orderFood = new OrderFoodController(listViewFoodOrder, cbFoodCategory, cbFood, numUDCountFood);
            dateTimeBooking.Format = DateTimePickerFormat.Custom;
            dateTimeBooking.CustomFormat = "MM/dd/yyyy HH:mm";

            loadsAll();
        }

        public void loadsAll()
        {
            List<ListFoodOrderDTO> listFoodOrder = FoodDAO.Instance.getListFoodOrderByIdBill(data.Bill.id);

            loadDataBooking.loadAll();
            orderFood.loadCategoryFood();
            orderFood.loadListFood(listFoodOrder, data.Bill.idTable);

            lbTotalPriceFood.Text = orderFood.updateTotalPrice().ToString();
        }
        public void changeLabelPriceOfTable()
        {
            string area = TableDAO.Instance.getAreaTable(data.Bill.idTable);
            label14.Text = area == "Khu thường" ? "Giá món ăn tính theo khu thường" : "Giá món ăn tính theo khu vip"; 
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFoodCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            orderFood.cbFoodCategory_SelectedValueChanged(sender, e);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            orderFood.handleOrderFood(false, 0);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadsAll();
        }

        private bool checkInputNumber()
        {
            if (int.TryParse(txbCountBooking.Text, out int countBooking) && int.TryParse(txbDepositBooking.Text, out int depositBooking))
            {
                if (countBooking >= 0 && depositBooking >= 0)
                {
                    return true;
                }
            }
            MessageBox.Show("Vui lòng nhập đúng định dạng số");
            return false;
        }

        private bool checkInputRequire()
        {
            if (txbIdCustomer.Text != "" && txbCountBooking.Text != "" && txbDepositBooking.Text != "" && cbTableBooking.SelectedIndex != -1)
            {
                return true;
            }
            MessageBox.Show("Vui lòng nhập đủ thông tin");
            return false;
        }

        private bool checkInput()
        {
            bool isValidRequire = checkInputRequire();
            if (!isValidRequire) return false;

            bool isValidNumber = checkInputNumber();
            if (!isValidNumber) return false;
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                int idTableChange = int.Parse(cbTableBooking.SelectedValue.ToString());
                BookingTableDAO.Instance.changeBookingTableInfo(data.Bill.id, dateTimeBooking.Value, int.Parse(txbDepositBooking.Text), int.Parse(txbCountBooking.Text), txbNoteBooking.Text);
                //đổi bàn
                BillDAO.Instance.changeIdTableAndListFoodOrder(data.Bill.id, idTableChange, listViewFoodOrder.Items);
                refesh(sender, e);
                this.Close();
            }
           
        }

        private void listViewFoodOrder_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewOrder.sort(e.Column);
        }
    }
}
