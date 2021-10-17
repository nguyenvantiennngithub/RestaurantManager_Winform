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
    public partial class fBookingTable : Form
    {
        public event EventHandler<EventArgs> refesh;
        private int idTable;
        private string username;
        SortListViewController sortListViewOrder;
        OrderFoodController orderFood;

        public fBookingTable(string username)
        {
            InitializeComponent();
            this.username = username;
            dateTimeBooking.Format = DateTimePickerFormat.Custom;
            dateTimeBooking.CustomFormat = "MM/dd/yyyy HH:mm";
            dateTimeBooking.MinDate = DateTime.Now;//Phari datwdj truocws 3 tieengs
            sortListViewOrder = new SortListViewController(listViewFoodOrder);
            orderFood = new OrderFoodController(listViewFoodOrder, cbFoodCategory, cbFood, numUDCountFood);
        }

        private void fBookingTable_Load(object sender, EventArgs e)
        {
            List<ListFoodOrderDTO> listFoodOrder = FoodDAO.Instance.getListFoodOrderByIdTable(idTable);
            orderFood.loadCategoryFood();
            orderFood.loadListFood(listFoodOrder, 0);//0 là cho đại vì sẽ k dùng tới
            loadListTables();
        }

        private void loadListTables()
        {
            List<Table> listTable = TableDAO.Instance.getTables();
            cbTableBooking.DisplayMember = "displayName";
            cbTableBooking.ValueMember = "id";
            cbTableBooking.DataSource = listTable;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            orderFood.handleOrderFood(false, 0);
            lbTotalPriceFood.Text = orderFood.updateTotalPrice().ToString();
        }

        private void cbFoodCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            orderFood.loadFoodWhenSelectFoodCategory();
        }

        private void txbIdCustomer_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txbIdCustomer_Leave(object sender, EventArgs e)
        {
            MessageBox.Show(txbIdCustomer.Text);
        }

        private void lbSelectCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fShowListInfoCustomer showListInfoCustomerForm = new fShowListInfoCustomer();
            var result = showListInfoCustomerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                txbIdCustomer.Text = showListInfoCustomerForm.IdCustomer;
                txbNameCustomer.Text = showListInfoCustomerForm.DisplayName;
                txbAddressCustomer.Text = showListInfoCustomerForm.Address;
                txbPhoneCustomer.Text = showListInfoCustomerForm.Phone;
                rdoFemaleCustomer.Checked = showListInfoCustomerForm.Gender == "Nữ";
                rdoMaleCustomer.Checked = showListInfoCustomerForm.Gender == "Nam";
            }
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
        private void insertListFood(int idBill)
        {
            foreach (ListViewItem item in listViewFoodOrder.Items)
            {
                BillDetailDAO.Instance.addBillDetailByIdBill(new BillDetail()
                {
                    idBill = idBill,
                    displayNameFood = item.SubItems[1].Text,
                    countFood = int.Parse(item.SubItems[3].Text),
                });
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                int idBookingTable = BookingTableDAO.Instance.addBookingTableInfo(dateTimeBooking.Value, int.Parse(txbDepositBooking.Text), int.Parse(txbCountBooking.Text), txbNoteBooking.Text);
                int idBill = TableDAO.Instance.addBillAndChangeStatusTable(int.Parse(cbTableBooking.SelectedValue.ToString()), username, "Đặt trước" , null, int.Parse(txbIdCustomer.Text), idBookingTable);
                insertListFood(idBill);
                MessageBox.Show("Đặt bàn thành công");
                refesh(this, e);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listViewFoodOrder_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewOrder.sort(e.Column);
        }
    }
}
