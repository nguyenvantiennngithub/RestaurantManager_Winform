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
    public partial class fShowListBookingTable : Form
    {
        private string username;
        public event EventHandler<EventArgs> refesh;
        List<BookingTableDTO> listBookTable = BookingTableDAO.Instance.getListBookingTable();
        public fShowListBookingTable(string username)
        {
            InitializeComponent();
            this.username = username;
            loads();
        }

        private void loads()
        {
            dgvMain.Rows.Clear();
            int i = 1;
            foreach (BookingTableDTO item in listBookTable)
            {
                var index = dgvMain.Rows.Add();
                dgvMain.Rows[index].Cells["index"].Value = i.ToString();
                dgvMain.Rows[index].Cells["idTable"].Value = item.Bill.idTable.ToString();
                dgvMain.Rows[index].Cells["idBill"].Value = item.Bill.id;
                dgvMain.Rows[index].Cells["customerName"].Value = item.Customer.displayName;
                dgvMain.Rows[index].Cells["customerPhone"].Value = item.Customer.phoneNumber;
                dgvMain.Rows[index].Cells["customerNumber"].Value = item.BookingTable.count;
                dgvMain.Rows[index].Cells["time"].Value = item.BookingTable.time;
                i++;
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int index = int.Parse(senderGrid.Rows[e.RowIndex].Cells["index"].Value.ToString()) - 1;
                int idTable = int.Parse(senderGrid.Rows[e.RowIndex].Cells["idTable"].Value.ToString());
                int idBill = int.Parse(senderGrid.Rows[e.RowIndex].Cells["idBill"].Value.ToString());
                switch (e.ColumnIndex)
                {
                    //xem
                    case 7:
                        
                        fShowBookingTable showBookingTableForm = new fShowBookingTable(listBookTable[index]);
                        showBookingTableForm.ShowDialog();
                        break;
                    //sua
                    case 8:
                        fEditBookingTable editBookingTableForm = new fEditBookingTable(listBookTable[index]);
                        editBookingTableForm.refesh += refeshEvent;
                        editBookingTableForm.ShowDialog();
                        break;
                    //nhap tiec
                    case 9:
                        bool isTableActive = TableDAO.Instance.checkTableActiveByIdTable(idTable);
                        if (isTableActive)
                        {
                            MessageBox.Show("Bàn này đang có khách và chưa tính tiền vì thế không thể bắt đầu nhập tiệc ngay lúc này");
                            break;
                        }

                        MessageBox.Show("Nhập tiệc thành công");
                        BillDAO.Instance.changeDateCheckinAndStatusBill(idBill);
                        refeshEvent(sender, e);
                        break;
                    //huy
                    case 10:
                        DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy đặt bàn này không?", "Thông báo quan trọng", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            BillDAO.Instance.changeIsDeleteBill(idBill);
                            refeshEvent(sender, e);
                        }
                         break;
                }
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refeshEvent(object sender, EventArgs e)
        {
            listBookTable = BookingTableDAO.Instance.getListBookingTable();
            loads();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            fBookingTable bookingTableForm = new fBookingTable(username);
            bookingTableForm.refesh += refeshEvent;
            bookingTableForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            refesh(this, e);
            this.Close();
        }
        private void fShowListBookingTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            refesh(this, e);
        }
    } 
}
