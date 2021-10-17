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
    public partial class fShowBookingTable : Form
    {
        private BookingTableDTO data;//toàn bộ về đặt bàn trừ món ăn
        OrderFoodController orderFood;
        LoadDataBookingController loadDataBooking;
        SortListViewController sortListViewOrder;
        public fShowBookingTable(BookingTableDTO data)
        {
            InitializeComponent();
            this.data = data;
            orderFood = new OrderFoodController(listViewFoodOrder);
            sortListViewOrder = new SortListViewController(listViewFoodOrder);
            loadDataBooking = new LoadDataBookingController(data, txbIdCustomer, txbNameCustomer, txbPhoneCustomer,
               txbAddressCustomer, rdoMaleCustomer, rdoFemaleCustomer, cbTableBooking, dateTime,
               txbCountBooking, txbDepositBooking, txbNoteBooking);

            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "MM/dd/yyyy HH:mm";
            LoadAll();


        }
        private void LoadAll()
        {
            List<ListFoodOrderDTO> listFoodOrder = FoodDAO.Instance.getListFoodOrderByIdBill(data.Bill.id);
            loadDataBooking.loadAll();
            orderFood.loadListFood(listFoodOrder, data.Bill.idTable);
            lbTotalPriceFood.Text = orderFood.updateTotalPrice().ToString();
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewFoodOrder_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewOrder.sort(e.Column);
        }
    }
}
