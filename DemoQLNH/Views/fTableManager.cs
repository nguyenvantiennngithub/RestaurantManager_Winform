using System;
using System.Collections;
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
    public partial class fTableManager : Form
    {
        private string username;
        int g_idTable = 0;
        Panel g_panelAnimation;
        SortListViewController sortListViewOrder;
        SortListViewController sortListViewBookingTable;
        OrderFoodController orderFood;
        public fTableManager(string username)
        {
            InitializeComponent();
            this.username = username;
            orderFood = new OrderFoodController(listViewFoodOrder, cbFoodCategory, cbFood, numUDCountFood);
            
            loadTables();
            orderFood.loadCategoryFood();
            sortListViewOrder = new SortListViewController(listViewFoodOrder);
            sortListViewBookingTable = new SortListViewController(lvBookingTable);
            listViewFoodOrder.FullRowSelect = true;
            lvBookingTable.FullRowSelect = true;
        }
        #region Loads function

        private void loadTables()
        {
            flpTable.Controls.Clear();

            var listTable = TableDAO.Instance.getTables();
            foreach (Table table in listTable)
            {
                createTable(table);
            }
        }
        
        #endregion

        #region order food
        private void cbFoodCategory_SelectedValueChanged(object sender, EventArgs e)
        {

            orderFood.cbFoodCategory_SelectedValueChanged(sender, e);
        }

        private void loadsListBookingTable(List<BookingTableDTO> listBookTable)
        {
            int i = 0;
            lvBookingTable.Items.Clear();
            foreach (BookingTableDTO item in listBookTable)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString());
                listViewItem.SubItems.Add(item.Customer.displayName);
                listViewItem.SubItems.Add(item.BookingTable.count.ToString());
                listViewItem.SubItems.Add(item.BookingTable.time.Value.ToString("HH:mm dd/MM/yyyy"));
                lvBookingTable.Items.Add(listViewItem);
                i++;
            }
        }

        private void panelTable_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            g_idTable = int.Parse(pnl.Name);//doi idTable
            bool isActive = TableDAO.Instance.getStatusTable(g_idTable);
            string labelNameTable = TableDAO.Instance.getInfoTable(int.Parse(pnl.Name)).displayName;

            List<ListFoodOrderDTO> listFoodOrder = FoodDAO.Instance.getListFoodOrderByIdTable(int.Parse(pnl.Name));
            List<BookingTableDTO> listBookingTable = BookingTableDAO.Instance.getListBookingTableByIdTable(g_idTable);
            
            orderFood.loadListFood(listFoodOrder, g_idTable);
            loadsListBookingTable(listBookingTable);
            setButtonWhenChangeTable(isActive);
            changeBackgroundTable(pnl);

            lbNameCurrentTable.Text = "Thực đơn: " + labelNameTable;
            lbTotalPrice.Text = orderFood.updateTotalPrice().ToString();
        }
        #endregion

        #region handle form display
        public void btnRefesh_Click(object sender, EventArgs e)
        {
            g_idTable = 0;

            listViewFoodOrder.Items.Clear();
            lvBookingTable.Items.Clear();


            lbNameCurrentTable.Text = "Thực đơn bàn: Chưa chọn";
            lbTotalPrice.Text = "0";
            rdoAreaAll.Checked = true;
            rdoTableAll.Checked = true;

            loadTables();
            setButtonWhenChangeTable(false);
        }
        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin f = new fAdmin();
            f.ShowDialog();
            this.Show();
        }

        private void tsmChangeInfo_Click(object sender, EventArgs e)
        {
            fCheckPassword fcp = new fCheckPassword(username);
            DialogResult isValid = fcp.ShowDialog();

            if (isValid == DialogResult.Yes)
            {
                User user = UserDAO.Instance.getInfoUser(username);
                fPersonalInfomation fInfo = new fPersonalInfomation(user);
                fInfo.ShowDialog();
            }
        }
        private void panelTable_MouseHover(object sender, EventArgs e)
        {
            Panel pnl = (sender as Panel);
            if (g_panelAnimation != null)
            {
                setBackgroundColorPanel(g_panelAnimation, "Leave");
            }
            g_panelAnimation = pnl;
            setBackgroundColorPanel(pnl, "Hover");
        }
        private void panelTable_MouseLeave(object sender, EventArgs e)
        {

            Panel pnl = (sender as Panel);
            if (!pnl.ClientRectangle.Contains(pnl.PointToClient(Cursor.Position)))
            {
                setBackgroundColorPanel(pnl, "Leave");
            }
        }

        private void rdoFilterTable_Click(object sender, EventArgs e)
        {
            filterTable();
        }

        private bool checkIsChooseTable(string message)
        {
            if (g_idTable == 0)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        private bool alertTimeBookingTable()
        {
            BookingTable bookingTable = BookingTableDAO.Instance.getTimeOfBookingTableNearstByIdTable(g_idTable);
            
            if (bookingTable == null)
            {
                return true;
            }

            var time = bookingTable.time.Value.Subtract(DateTime.Now);
            if (DateTime.Now.Year == bookingTable.time.Value.Year &&//check cung ngay
                DateTime.Now.Month == bookingTable.time.Value.Month &&//va time nhỏ hơn 3 tiếng
                DateTime.Now.Day == bookingTable.time.Value.Day && time.Hours < 5)
            {

                string message = "Hôm nay bàn này được đặt vào lúc" + time.Hours + " giờ" + time.Minutes + " phút \nBạn có muốn tiếp tục order tại bàn này không?\nNếu có dấu trừ phía trước là thời gian đặt bàn đã truôi qua";
                DialogResult result = MessageBox.Show(message, "Thông báo",MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (!checkIsChooseTable("Bạn chưa chọn bàn, vui lòng chọn bàn")) return;
            
            string status = TableDAO.Instance.getInfoTable(g_idTable).status;
            
            if (status == "Bàn trống" || status == "Bàn đặt trước")
            {

                if (!alertTimeBookingTable()) return;

                TableDAO.Instance.addBillAndChangeStatusTable(g_idTable, username, "Chưa tính tiền", null, null, null);
                setDisplayTableWhenChangeTable();
            }

            orderFood.handleOrderFood(true, g_idTable);
            setButtonWhenChangeTable(true);

            lbTotalPrice.Text = orderFood.updateTotalPrice().ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!checkIsChooseTable("Bạn chưa chọn bàn, vui lòng chọn bàn")) return;
            bool isActive = TableDAO.Instance.getStatusTable(g_idTable);
            if (isActive)
            {
                var control = flpTable.Controls.Find(g_idTable.ToString(), false)[0];
                Panel currentPanel = control as Panel;
                Bill bill = BillDAO.Instance.getBill(g_idTable);
                fPay f = new fPay(bill, g_idTable, lbTotalPrice.Text);

                f.refesh += btnRefesh_Click;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bàn chưa có khách sao mà tính tiền được ??");
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            fMoveTable fmt = new fMoveTable(g_idTable, username);
            fmt.refesh += btnRefesh_Click;
            fmt.ShowDialog();
        }

        private void listViewFoodOrder_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewOrder.sort(e.Column);
        }

        private void btnShowfInfoCustomer_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.getIdBillByIdtableStatus(g_idTable, "Chưa tính tiền");
            fInfoCustomer frmInfoCustomer = new fInfoCustomer(idBill);
            frmInfoCustomer.ShowDialog();
        }

        private void đặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == true)
            {
                if (MessageBox.Show("Bạn có chắc muốn đóng chương trình không", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void fTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Filter table



        private void changeBackgroundTable(Panel pnl)
        {
            if (g_panelAnimation != null)
            {
                setBackgroundColorPanel(g_panelAnimation, "Leave");
            }
            g_panelAnimation = pnl;
            setBackgroundColorPanel(pnl, "Hover");
        }
        private bool checkFilterTableRdoBooking(int idTable, RadioButton rdoArea, List<TableGroupByIdAndAreaDTO> listTableBooking)
        {
            foreach (TableGroupByIdAndAreaDTO item in listTableBooking)
            {
                if (item.Id == idTable)
                {
                    if ((rdoArea.Text == "Tất cả" || rdoArea.Text == item.DisplayNameArea))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool checkFilterTableRdoOrder(Panel pnl, RadioButton rdoStatus, RadioButton rdoArea)
        {
            Label lbStatus = pnl.Controls.OfType<Label>().Where(lb => lb.Name == "lbStatus" + pnl.Name).FirstOrDefault();
            Label lbArea = pnl.Controls.OfType<Label>().Where(lb => lb.Name == "lbArea" + pnl.Name).FirstOrDefault();
            if ((rdoStatus.Text == "Tất cả" && rdoArea.Text == "Tất cả") ||
                (rdoStatus.Text == "Tất cả" && rdoArea.Text == lbArea.Text) ||
                (rdoStatus.Text == lbStatus.Text && rdoArea.Text == "Tất cả") ||
                (rdoStatus.Text == lbStatus.Text && rdoArea.Text == lbArea.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


       


        private void filterTable()
        {
            RadioButton rdoStatus = pnlTable.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rdoArea = pnlArea.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            List<TableGroupByIdAndAreaDTO> listTableBooking = TableDAO.Instance.getListTableHasBooking();

            foreach (Panel pnl in flpTable.Controls)
            {
                bool isShow;
                if (rdoStatus.Text == "Bàn đặt trước")
                {
                    isShow = checkFilterTableRdoBooking(int.Parse(pnl.Name), rdoArea, listTableBooking);
                }
                else
                {
                    isShow = checkFilterTableRdoOrder(pnl, rdoStatus, rdoArea);
                }

                if (isShow) pnl.Show();
                else pnl.Hide();
            }
        }


        #endregion

        #region Handle create and animation table

        private void setBackgroundColorPanel(Panel pnl, string nameEvent)
        {
            string status = TableDAO.Instance.getInfoTable(int.Parse(pnl.Name)).status;
            if (status == "Bàn trống")
            {
                pnl.BackColor = nameEvent == "Hover" ? SettingController.Instance.BgcTableFreeHover : SettingController.Instance.BgcTableFree;
            }
            else if (status == "Bàn có khách")
            {
                pnl.BackColor = nameEvent == "Hover" ? SettingController.Instance.BgcTableActiveHover : SettingController.Instance.BgcTableActive;
            }
            else if (status == "Bàn đặt trước")
            {
                pnl.BackColor = nameEvent == "Hover" ? SettingController.Instance.BgcTableBookingHover : SettingController.Instance.BgcTableBooking;
            }
            else
            {
                MessageBox.Show("Error: set status at setBackgroundColor");
            }
        }


        private void createTable(Table table)
        {
            //init
            Panel panel = new Panel();
            Label lbName = new Label();
            Label lbArea = new Label();
            Label lbStatus = new Label();

            //Panel
            Color cl;
            panel.Size = new Size(154, 100);
            panel.BorderStyle = BorderStyle.FixedSingle;
            if (table.status == "Bàn trống")
            {
                panel.BackColor = SettingController.Instance.BgcTableFree;
                cl = SettingController.Instance.textColorFree;
            }
            else if (table.status == "Bàn có khách")
            {
                panel.BackColor = SettingController.Instance.BgcTableActive;
                cl = SettingController.Instance.textColorActive;
            }
            else if (table.status == "Bàn đặt trước")
            {
                panel.BackColor = SettingController.Instance.BgcTableBooking;
                cl = SettingController.Instance.textColorActive;
            }
            else
            {
                MessageBox.Show("Error: set background color createTable");
                cl = SettingController.Instance.textColorActive;
            }
            panel.Name = table.id.ToString();


            //Label name
            lbName.Text = table.displayName;
            lbName.Name = "lbName" + table.id.ToString();
            lbName.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbName.Location = new Point(5, 5);
            lbName.AutoSize = false;
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            lbName.ForeColor = cl;

            //Label area
            lbArea.Text = table.displayNameArea;
            lbArea.Name = "lbArea" + table.id.ToString();
            lbArea.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbArea.Location = new Point(panel.Width - lbArea.Width - 5, 5);
            lbArea.AutoSize = false;
            lbArea.TextAlign = ContentAlignment.MiddleRight;
            lbArea.ForeColor = cl;

            //Label status
            lbStatus.Text = table.status;
            lbStatus.Name = "lbStatus" + table.id.ToString();
            lbStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbStatus.Location = new Point((panel.Width - lbStatus.Width) / 2, (int)(panel.Height / 1.5));
            lbStatus.AutoSize = false;
            lbStatus.TextAlign = ContentAlignment.MiddleCenter;

            //event for panel
            panel.Click += panelTable_Click;

            //EVENT CLICK FOR 3 LABEL
            lbName.Click += delegate (object sender, EventArgs e) { panelTable_Click(panel, e); };
            lbArea.Click += delegate (object sender, EventArgs e) { panelTable_Click(panel, e); };
            lbStatus.Click += delegate (object sender, EventArgs e) { panelTable_Click(panel, e); };
            //add controll
            panel.Controls.Add(lbArea);
            panel.Controls.Add(lbName);
            panel.Controls.Add(lbStatus);

            flpTable.Controls.Add(panel);
        }

        #endregion

        private int checkFoodOrdered(string nameFoodOrder)
        {
            foreach (ListViewItem listItem in listViewFoodOrder.Items)
            {
                if (listItem.SubItems[1].Text == nameFoodOrder) return listItem.Index;//index = 1 la displayNameFood
            }
            return -1;
        }

        private void setButtonWhenChangeTable(bool isChecked)
        {
            btnShowfPay.Enabled = isChecked;
            btnMove.Enabled = isChecked;
            btnShowfInfoCustomer.Enabled = isChecked;
        }

        private void setDisplayTableWhenChangeTable()
        {
            var control = flpTable.Controls.Find(g_idTable.ToString(), false)[0];
            Panel currentPanel = control as Panel;
            
            currentPanel.BackColor = SettingController.Instance.BgcTableActiveHover;
            currentPanel.Controls.Find("lbArea" + currentPanel.Name, false)[0].ForeColor = SettingController.Instance.textColorActive;
            currentPanel.Controls.Find("lbName" + currentPanel.Name, false)[0].ForeColor = SettingController.Instance.textColorActive;
            currentPanel.Controls.Find("lbStatus" + currentPanel.Name, false)[0].Text = "Bàn có khách";
        }

        private void đặtBànToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fBookingTable bookingTableForm = new fBookingTable(username);
            bookingTableForm.refesh += btnRefesh_Click;
            bookingTableForm.ShowDialog();
        }

        private void xemDanhSáchBànĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShowListBookingTable showListBookingTableForm = new fShowListBookingTable(username);
            showListBookingTableForm.refesh += btnRefesh_Click;
            showListBookingTableForm.ShowDialog();
        }

        private void lvBookingTable_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListViewBookingTable.sort(e.Column);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
