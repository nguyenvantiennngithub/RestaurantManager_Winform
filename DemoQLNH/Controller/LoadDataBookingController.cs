using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
   
    class LoadDataBookingController
    {
        private BookingTableDTO data;//toàn bộ về đặt bàn trừ món ăn
        TextBox txbIdCustomer;
        TextBox txbNameCustomer;
        TextBox txbPhoneCustomer;
        TextBox txbAddressCustomer;
        RadioButton rdoMaleCustomer;
        RadioButton rdoFemaleCustomer;
        ComboBox cbTableBooking;
        DateTimePicker dateTime;
        TextBox txbCountBooking;
        TextBox txbDepositBooking;
        RichTextBox txbNoteBooking;

        public BookingTableDTO Data { get => data; set => data = value; }
        public TextBox TxbIdCustomer { get => txbIdCustomer; set => txbIdCustomer = value; }
        public TextBox TxbNameCustomer { get => txbNameCustomer; set => txbNameCustomer = value; }
        public TextBox TxbPhoneCustomer { get => txbPhoneCustomer; set => txbPhoneCustomer = value; }
        public TextBox TxbAddressCustomer { get => txbAddressCustomer; set => txbAddressCustomer = value; }
        public RadioButton RdoMaleCustomer { get => rdoMaleCustomer; set => rdoMaleCustomer = value; }
        public RadioButton RdoFemaleCustomer { get => rdoFemaleCustomer; set => rdoFemaleCustomer = value; }
        public ComboBox CbTableBooking { get => cbTableBooking; set => cbTableBooking = value; }
        public DateTimePicker DateTime { get => dateTime; set => dateTime = value; }
        public TextBox TxbCountBooking { get => txbCountBooking; set => txbCountBooking = value; }
        public TextBox TxbDepositBooking { get => txbDepositBooking; set => txbDepositBooking = value; }
        public RichTextBox TxbNoteBooking { get => txbNoteBooking; set => txbNoteBooking = value; }

        public LoadDataBookingController(BookingTableDTO data, TextBox txbIdCustomer, TextBox txbNameCustomer, TextBox txbPhoneCustomer, TextBox txbAddressCustomer, RadioButton rdoMaleCustomer, RadioButton rdoFemaleCustomer, ComboBox cbTableBooking, DateTimePicker dateTime, TextBox txbCountBooking, TextBox txbDepositBooking, RichTextBox txbNoteBooking)
        {
            this.Data = data;
            this.TxbIdCustomer = txbIdCustomer;
            this.TxbNameCustomer = txbNameCustomer;
            this.TxbPhoneCustomer = txbPhoneCustomer;
            this.TxbAddressCustomer = txbAddressCustomer;
            this.RdoMaleCustomer = rdoMaleCustomer;
            this.RdoFemaleCustomer = rdoFemaleCustomer;
            this.CbTableBooking = cbTableBooking;
            this.DateTime = dateTime;
            this.TxbCountBooking = txbCountBooking;
            this.TxbDepositBooking = txbDepositBooking;
            this.TxbNoteBooking = txbNoteBooking;
        }
        public void loadAll()
        {
            loadsCustomer();
            loadListTables();
            loadsBookingTable();
        }

        private void loadsCustomer()
        {
            TxbIdCustomer.Text = Data.Customer.id.ToString();
            TxbNameCustomer.Text = Data.Customer.displayName;
            TxbPhoneCustomer.Text = Data.Customer.phoneNumber;
            TxbAddressCustomer.Text = Data.Customer.address;
            RdoMaleCustomer.Checked = Data.Customer.gender == "Nam";
            RdoFemaleCustomer.Checked = Data.Customer.gender == "Nữ";
        }
        private void loadListTables()
        {
            List<Table> listTable = TableDAO.Instance.getTables();
            CbTableBooking.DisplayMember = "displayName";
            CbTableBooking.ValueMember = "id";
            CbTableBooking.DataSource = listTable;
        }
        private void loadsBookingTable()
        {
            DateTime.Value = (DateTime)Data.BookingTable.time;
            CbTableBooking.SelectedValue = Data.Bill.idTable;
            TxbCountBooking.Text = Data.BookingTable.count.ToString();
            TxbDepositBooking.Text = Data.BookingTable.deposit.ToString();
            TxbNoteBooking.Text = Data.BookingTable.description;
        }
    }
}
