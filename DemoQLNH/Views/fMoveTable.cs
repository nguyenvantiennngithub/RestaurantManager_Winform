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
    public partial class fMoveTable : Form
    {
        private string username;
        private int idTable;
        private bool isMoveFood = false;//Kiểm tra việc đổi bàn nếu đã move foood khi đổi 1 bàn thì bàn bên kia phải render lại
        public event EventHandler<EventArgs> refesh;
        SortListViewController sortListViewReceiver;
        SortListViewController sortListViewSender;


        public fMoveTable(int idTable, string username)
        {
            this.idTable = idTable;
            this.username = username;

            InitializeComponent();
            loads();

            sortListViewSender = new SortListViewController(lvSender);
            sortListViewReceiver = new SortListViewController(lvReceiver);

        }

        private void loadsListViewFood(ComboBox comboBox)
        {
            int i = 0;
            comboBox.ValueMember = "id";
            int idTable = int.Parse(comboBox.SelectedValue.ToString());
            ListView lv = comboBox.Parent.Controls.OfType<ListView>().First();
            List<ListFoodOrderDTO> listFood = FoodDAO.Instance.getListFoodOrderByIdTable(idTable);
            string displayNameAreaTable = TableDAO.Instance.getAreaTable(idTable);
            
            lv.Items.Clear();
            foreach (ListFoodOrderDTO food in listFood)
            {
                int price = displayNameAreaTable == "Khu vip" ? food.PriceVip : food.PriceNormal; 
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(food.DisplayNameFood);
                listViewItem.SubItems.Add(price.ToString());
                listViewItem.SubItems.Add(food.Count.ToString());
                lv.Items.Add(listViewItem);
                i++;
            }
        }

        private void cb_SelectedIndexCheckSameTable(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (cbReceiver.SelectedValue == cbSender.SelectedValue)
            {
                MessageBox.Show("Bạn đã chọn trùng bàn, vui lòng chọn bàn khác");
                comboBox.SelectedIndex = -1;
            }
        }

        private void cb_SelectedIndexReloadData(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.SelectedIndex != -1)//load list view by item of combobox
            {
                loadsListViewFood(comboBox);

                if (isMoveFood)
                {
                    lvReceiver.Items.Clear();
                }
            }
        }

        private void cb_SelectedIndexClearData(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.SelectedIndex != -1)//load list view by item of combobox
            {
                lvReceiver.Items.Clear();
                if (isMoveFood)
                {
                    loadsListViewFood(cbSender);
                }
            }
        }
        private void loads()
        {
            List<Table> tables1 = TableDAO.Instance.getTablesActive();
            List<Table> tables2 = TableDAO.Instance.getTables();


            cbSender.DataSource = tables1;
            cbSender.DisplayMember = "displayName";
            cbSender.ValueMember = "id";
            cbSender.SelectedValue = idTable;

            loadsListViewFood(cbSender);


            cbReceiver.DataSource = tables2;
            cbReceiver.DisplayMember = "displayName";
            cbReceiver.SelectedIndex = -1;

            lvSender.FullRowSelect = true;
            lvReceiver.FullRowSelect = true;

            cbSender.SelectedIndexChanged += cb_SelectedIndexCheckSameTable;
            cbReceiver.SelectedIndexChanged += cb_SelectedIndexCheckSameTable;
            cbSender.SelectedIndexChanged += cb_SelectedIndexReloadData;
            cbReceiver.SelectedIndexChanged += cb_SelectedIndexClearData;



        }
        private void fMoveTable_Load(object sender, EventArgs e)
        {

        }

        private int checkExistItem(ListView lvReceiver, string displayNameFood)
        {
            foreach (ListViewItem item in lvReceiver.Items)
            {
                if (item.SubItems[1].Text == displayNameFood)//index = 1 là tên food
                {
                    return item.Index;
                }
            }
            return -1;
        }

        private void moveFoodToListViewReceiver(ListView lvReceiver, ListViewItem itemMove, int indexReceiver)
        {
        
            ListViewItem lvi = new ListViewItem(lvReceiver.Items.Count.ToString());
            lvi.SubItems.Add(itemMove.SubItems[1].Text);
            lvi.SubItems.Add(itemMove.SubItems[2].Text);
            lvi.SubItems.Add(itemMove.SubItems[3].Text);
            lvReceiver.Items.Add(lvi);
        }


        private void removeFoodListViewSender(ListView lvSender, ListViewItem itemMove)
        {
            //sau khi xóa thì những thằng phía sau index phải --
            bool flagReduceIndexAfterRemove = false;
            foreach (ListViewItem lvItem in lvSender.Items)
            {
                if (lvItem == itemMove)
                {
                    int currentIndex = itemMove.Index;
                    lvSender.Items.Remove(itemMove);
                    flagReduceIndexAfterRemove = true;

                    if (currentIndex != lvSender.Items.Count)
                    {
                        lvSender.Items[currentIndex].Selected = true;
                    }
                }
                else if (flagReduceIndexAfterRemove)
                {
                    lvItem.SubItems[0].Text = (int.Parse(lvItem.SubItems[0].Text) - 1).ToString();
                }
            }
        }


        private void handleMoveTable(ListView lvSender, ListView lvReceiver, IEnumerable<ListViewItem> lvSelected)
        {

            if (cbSender.SelectedIndex != -1 && cbReceiver.SelectedIndex != -1)
            {
                foreach (ListViewItem item in lvSelected)
                {
                    int indexReceiver = checkExistItem(lvReceiver, item.SubItems[1].Text);
               
                    moveFoodToListViewReceiver(lvReceiver, item, indexReceiver);
                    removeFoodListViewSender(lvSender, item);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đủ bàn kìa ");
            }
        }

        private void btnSender_Click(object sender, EventArgs e)
        {  
            handleMoveTable(lvSender, lvReceiver, lvSender.SelectedItems.OfType<ListViewItem>());
            isMoveFood = true;
        }

        private void btnSenderAll_Click(object sender, EventArgs e)
        {  
            handleMoveTable(lvSender, lvReceiver, lvSender.Items.OfType<ListViewItem>());
            isMoveFood = true;
        }

        private void btnReceiver_Click(object sender, EventArgs e)
        {  
            handleMoveTable(lvReceiver, lvSender, lvReceiver.SelectedItems.OfType<ListViewItem>());
            isMoveFood = true;
        }

        private void btnReceiverAll_Click(object sender, EventArgs e)
        {  
            handleMoveTable(lvReceiver, lvSender, lvReceiver.Items.OfType<ListViewItem>());
            isMoveFood = true;
        }

        private bool checkIndexCombobox()
        {
            return (cbSender.SelectedIndex != -1 && cbReceiver.SelectedIndex != -1);
        }

        private DialogResult alertYesNo()
        {
            return  MessageBox.Show("Bạn chắc chắn muốn chuyển không???", "Thông báo quan trọng", MessageBoxButtons.YesNo);
            
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkIndexCombobox())
            {
                MessageBox.Show("Chưa chọn bàn, vui lòng chọn bàn");
                return;
            }
            if (alertYesNo() == DialogResult.No) return;
            
            cbReceiver.ValueMember = "id";
            int idTableSender = int.Parse(cbSender.SelectedValue.ToString());
            int idTableReceiver = int.Parse(cbReceiver.SelectedValue.ToString());
            bool isActive = TableDAO.Instance.getStatusTable(idTableReceiver);

            if (!isActive)
            {
                TableDAO.Instance.addBillAndChangeStatusTable(idTableReceiver, username, "Chưa tính tiền", null, null, null);
                if (lvSender.Items.Count == 0)
                {
                    MoveFoodDAO.Instance.moveAllFoodToFreeTable(idTableSender, idTableReceiver);
                }
                else
                {
                    MoveFoodDAO.Instance.moveSomeFoodToFreeTable(idTableSender, idTableReceiver, lvReceiver.Items);
                }
            }
            else
            {
                if (lvSender.Items.Count == 0)
                {
                    MoveFoodDAO.Instance.moveAllFoodToActiveTable(idTableSender, idTableReceiver);
                }
                else
                {
                    MoveFoodDAO.Instance.moveSomeFoodToActiveTable(idTableSender, idTableReceiver, lvReceiver.Items);
                }
            }
            refesh(this, e);
            this.Hide();

        }

        private void cbReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lvSender_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewSender.sort(e.Column);
        }

        private void lvReceiver_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewReceiver.sort(e.Column);
        }
    }
}
