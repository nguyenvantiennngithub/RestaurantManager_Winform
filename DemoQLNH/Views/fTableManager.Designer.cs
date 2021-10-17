
namespace DemoQLNH
{
    partial class fTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.lbNameCurrentTable = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpOrderFood = new System.Windows.Forms.TabPage();
            this.listViewFoodOrder = new System.Windows.Forms.ListView();
            this.ASC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnDisplayname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewColumnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewColumnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvBookingTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefesh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowfInfoCustomer = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowfPay = new System.Windows.Forms.Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUDCountFood = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlArea = new System.Windows.Forms.Panel();
            this.rdoAreaAll = new System.Windows.Forms.RadioButton();
            this.rdoAreaVip = new System.Windows.Forms.RadioButton();
            this.rdoAreNormal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.rdoBookingTable = new System.Windows.Forms.RadioButton();
            this.rdoTableAll = new System.Windows.Forms.RadioButton();
            this.rdoTableFree = new System.Windows.Forms.RadioButton();
            this.rdoTableActive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ChangeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtBànToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchBànĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpOrderFood.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCountFood)).BeginInit();
            this.pnlArea.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbNameCurrentTable);
            this.panel.Controls.Add(this.tcMain);
            this.panel.Controls.Add(this.btnRefesh);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.flpTable);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.pnlArea);
            this.panel.Controls.Add(this.pnlTable);
            this.panel.Controls.Add(this.menuStrip1);
            this.panel.Location = new System.Drawing.Point(1, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1150, 525);
            this.panel.TabIndex = 0;
            // 
            // lbNameCurrentTable
            // 
            this.lbNameCurrentTable.AutoSize = true;
            this.lbNameCurrentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCurrentTable.Location = new System.Drawing.Point(518, 102);
            this.lbNameCurrentTable.Name = "lbNameCurrentTable";
            this.lbNameCurrentTable.Size = new System.Drawing.Size(159, 16);
            this.lbNameCurrentTable.TabIndex = 1;
            this.lbNameCurrentTable.Text = "Thực đơn bàn: Chưa chọn";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpOrderFood);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(683, 105);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(446, 341);
            this.tcMain.TabIndex = 1;
            // 
            // tpOrderFood
            // 
            this.tpOrderFood.Controls.Add(this.listViewFoodOrder);
            this.tpOrderFood.Location = new System.Drawing.Point(4, 22);
            this.tpOrderFood.Name = "tpOrderFood";
            this.tpOrderFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderFood.Size = new System.Drawing.Size(438, 315);
            this.tpOrderFood.TabIndex = 0;
            this.tpOrderFood.Text = "Thực đơn bàn có khách hiện tại";
            this.tpOrderFood.UseVisualStyleBackColor = true;
            // 
            // listViewFoodOrder
            // 
            this.listViewFoodOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFoodOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ASC,
            this.listViewColumnDisplayname,
            this.listViewColumnPrice,
            this.ListViewColumnCount,
            this.ListViewColumnTotal});
            this.listViewFoodOrder.HideSelection = false;
            this.listViewFoodOrder.Location = new System.Drawing.Point(0, -3);
            this.listViewFoodOrder.Name = "listViewFoodOrder";
            this.listViewFoodOrder.Size = new System.Drawing.Size(435, 322);
            this.listViewFoodOrder.TabIndex = 0;
            this.listViewFoodOrder.UseCompatibleStateImageBehavior = false;
            this.listViewFoodOrder.View = System.Windows.Forms.View.Details;
            this.listViewFoodOrder.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewFoodOrder_ColumnClick);
            // 
            // ASC
            // 
            this.ASC.Tag = "int";
            this.ASC.Text = "STT";
            this.ASC.Width = 33;
            // 
            // listViewColumnDisplayname
            // 
            this.listViewColumnDisplayname.Tag = "string";
            this.listViewColumnDisplayname.Text = "Tên món";
            this.listViewColumnDisplayname.Width = 165;
            // 
            // listViewColumnPrice
            // 
            this.listViewColumnPrice.Tag = "int";
            this.listViewColumnPrice.Text = "Đơn giá";
            this.listViewColumnPrice.Width = 99;
            // 
            // ListViewColumnCount
            // 
            this.ListViewColumnCount.Tag = "int";
            this.ListViewColumnCount.Text = "Số lượng";
            this.ListViewColumnCount.Width = 58;
            // 
            // ListViewColumnTotal
            // 
            this.ListViewColumnTotal.Tag = "int";
            this.ListViewColumnTotal.Text = "Tổng tiền";
            this.ListViewColumnTotal.Width = 92;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvBookingTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách lịch đặt của bàn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvBookingTable
            // 
            this.lvBookingTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBookingTable.HideSelection = false;
            this.lvBookingTable.Location = new System.Drawing.Point(-4, 0);
            this.lvBookingTable.Name = "lvBookingTable";
            this.lvBookingTable.Size = new System.Drawing.Size(439, 315);
            this.lvBookingTable.TabIndex = 0;
            this.lvBookingTable.UseCompatibleStateImageBehavior = false;
            this.lvBookingTable.View = System.Windows.Forms.View.Details;
            this.lvBookingTable.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvBookingTable_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "int";
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "string";
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "int";
            this.columnHeader3.Text = "Số lượng khách";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "time";
            this.columnHeader4.Text = "Thời gian đặt";
            this.columnHeader4.Width = 183;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(542, 41);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(95, 49);
            this.btnRefesh.TabIndex = 7;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowfInfoCustomer);
            this.panel4.Controls.Add(this.btnMove);
            this.panel4.Controls.Add(this.lbTotalPrice);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnShowfPay);
            this.panel4.Location = new System.Drawing.Point(683, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 86);
            this.panel4.TabIndex = 6;
            // 
            // btnShowfInfoCustomer
            // 
            this.btnShowfInfoCustomer.Enabled = false;
            this.btnShowfInfoCustomer.Location = new System.Drawing.Point(303, 16);
            this.btnShowfInfoCustomer.Name = "btnShowfInfoCustomer";
            this.btnShowfInfoCustomer.Size = new System.Drawing.Size(75, 56);
            this.btnShowfInfoCustomer.TabIndex = 19;
            this.btnShowfInfoCustomer.Text = "Thông tinh khách";
            this.btnShowfInfoCustomer.UseVisualStyleBackColor = true;
            this.btnShowfInfoCustomer.Click += new System.EventHandler(this.btnShowfInfoCustomer_Click);
            // 
            // btnMove
            // 
            this.btnMove.Enabled = false;
            this.btnMove.Location = new System.Drawing.Point(208, 16);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 56);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "Chuyển bàn";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.White;
            this.lbTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(14, 54);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(2, 18);
            this.lbTotalPrice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tổng tiền";
            // 
            // btnShowfPay
            // 
            this.btnShowfPay.Enabled = false;
            this.btnShowfPay.Location = new System.Drawing.Point(95, 16);
            this.btnShowfPay.Name = "btnShowfPay";
            this.btnShowfPay.Size = new System.Drawing.Size(75, 56);
            this.btnShowfPay.TabIndex = 4;
            this.btnShowfPay.Text = "Thanh toán";
            this.btnShowfPay.UseVisualStyleBackColor = true;
            this.btnShowfPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Location = new System.Drawing.Point(11, 119);
            this.flpTable.Name = "flpTable";
            this.flpTable.Padding = new System.Windows.Forms.Padding(3);
            this.flpTable.Size = new System.Drawing.Size(664, 389);
            this.flpTable.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.numUDCountFood);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbFoodCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(683, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 68);
            this.panel1.TabIndex = 4;
            // 
            // numUDCountFood
            // 
            this.numUDCountFood.Location = new System.Drawing.Point(347, 14);
            this.numUDCountFood.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUDCountFood.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUDCountFood.Name = "numUDCountFood";
            this.numUDCountFood.Size = new System.Drawing.Size(74, 20);
            this.numUDCountFood.TabIndex = 5;
            this.numUDCountFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(347, 40);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbFood
            // 
            this.cbFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(111, 40);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(191, 21);
            this.cbFood.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFoodCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(111, 13);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(191, 21);
            this.cbFoodCategory.TabIndex = 2;
            this.cbFoodCategory.SelectedValueChanged += new System.EventHandler(this.cbFoodCategory_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại món ăn";
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.rdoAreaAll);
            this.pnlArea.Controls.Add(this.rdoAreaVip);
            this.pnlArea.Controls.Add(this.rdoAreNormal);
            this.pnlArea.Controls.Add(this.label2);
            this.pnlArea.Location = new System.Drawing.Point(11, 31);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(240, 68);
            this.pnlArea.TabIndex = 3;
            // 
            // rdoAreaAll
            // 
            this.rdoAreaAll.AutoSize = true;
            this.rdoAreaAll.Checked = true;
            this.rdoAreaAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAreaAll.Location = new System.Drawing.Point(172, 39);
            this.rdoAreaAll.Name = "rdoAreaAll";
            this.rdoAreaAll.Size = new System.Drawing.Size(58, 19);
            this.rdoAreaAll.TabIndex = 5;
            this.rdoAreaAll.TabStop = true;
            this.rdoAreaAll.Text = "Tất cả";
            this.rdoAreaAll.UseVisualStyleBackColor = true;
            this.rdoAreaAll.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // rdoAreaVip
            // 
            this.rdoAreaVip.AutoSize = true;
            this.rdoAreaVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAreaVip.Location = new System.Drawing.Point(101, 39);
            this.rdoAreaVip.Name = "rdoAreaVip";
            this.rdoAreaVip.Size = new System.Drawing.Size(65, 19);
            this.rdoAreaVip.TabIndex = 4;
            this.rdoAreaVip.Text = "Khu vip";
            this.rdoAreaVip.UseVisualStyleBackColor = true;
            this.rdoAreaVip.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // rdoAreNormal
            // 
            this.rdoAreNormal.AutoSize = true;
            this.rdoAreNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAreNormal.Location = new System.Drawing.Point(7, 39);
            this.rdoAreNormal.Name = "rdoAreNormal";
            this.rdoAreNormal.Size = new System.Drawing.Size(88, 19);
            this.rdoAreNormal.TabIndex = 3;
            this.rdoAreNormal.Text = "Khu thường";
            this.rdoAreNormal.UseVisualStyleBackColor = true;
            this.rdoAreNormal.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khu vực";
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.rdoBookingTable);
            this.pnlTable.Controls.Add(this.rdoTableAll);
            this.pnlTable.Controls.Add(this.rdoTableFree);
            this.pnlTable.Controls.Add(this.rdoTableActive);
            this.pnlTable.Controls.Add(this.label1);
            this.pnlTable.Location = new System.Drawing.Point(257, 31);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(227, 87);
            this.pnlTable.TabIndex = 0;
            // 
            // rdoBookingTable
            // 
            this.rdoBookingTable.AutoSize = true;
            this.rdoBookingTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBookingTable.Location = new System.Drawing.Point(7, 63);
            this.rdoBookingTable.Name = "rdoBookingTable";
            this.rdoBookingTable.Size = new System.Drawing.Size(97, 19);
            this.rdoBookingTable.TabIndex = 3;
            this.rdoBookingTable.Text = "Bàn đặt trước";
            this.rdoBookingTable.UseVisualStyleBackColor = true;
            this.rdoBookingTable.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // rdoTableAll
            // 
            this.rdoTableAll.AutoSize = true;
            this.rdoTableAll.Checked = true;
            this.rdoTableAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTableAll.Location = new System.Drawing.Point(112, 63);
            this.rdoTableAll.Name = "rdoTableAll";
            this.rdoTableAll.Size = new System.Drawing.Size(58, 19);
            this.rdoTableAll.TabIndex = 2;
            this.rdoTableAll.TabStop = true;
            this.rdoTableAll.Text = "Tất cả";
            this.rdoTableAll.UseVisualStyleBackColor = true;
            this.rdoTableAll.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // rdoTableFree
            // 
            this.rdoTableFree.AutoSize = true;
            this.rdoTableFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTableFree.Location = new System.Drawing.Point(112, 39);
            this.rdoTableFree.Name = "rdoTableFree";
            this.rdoTableFree.Size = new System.Drawing.Size(78, 19);
            this.rdoTableFree.TabIndex = 1;
            this.rdoTableFree.Text = "Bàn trống";
            this.rdoTableFree.UseVisualStyleBackColor = true;
            this.rdoTableFree.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // rdoTableActive
            // 
            this.rdoTableActive.AutoSize = true;
            this.rdoTableActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTableActive.Location = new System.Drawing.Point(7, 39);
            this.rdoTableActive.Name = "rdoTableActive";
            this.rdoTableActive.Size = new System.Drawing.Size(99, 19);
            this.rdoTableActive.TabIndex = 0;
            this.rdoTableActive.Text = "Bàn có khách";
            this.rdoTableActive.UseVisualStyleBackColor = true;
            this.rdoTableActive.Click += new System.EventHandler(this.rdoFilterTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình trạng bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Admin,
            this.tàiKhoảnToolStripMenuItem,
            this.đặtBànToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Admin
            // 
            this.tsm_Admin.Name = "tsm_Admin";
            this.tsm_Admin.Size = new System.Drawing.Size(55, 20);
            this.tsm_Admin.Text = "Admin";
            this.tsm_Admin.Click += new System.EventHandler(this.tsmAdmin_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ChangeInfo,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // tsm_ChangeInfo
            // 
            this.tsm_ChangeInfo.Name = "tsm_ChangeInfo";
            this.tsm_ChangeInfo.Size = new System.Drawing.Size(171, 22);
            this.tsm_ChangeInfo.Text = "Thay đổi thông tin";
            this.tsm_ChangeInfo.Click += new System.EventHandler(this.tsmChangeInfo_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đặtBànToolStripMenuItem
            // 
            this.đặtBànToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtBànToolStripMenuItem1,
            this.xemDanhSáchBànĐặtToolStripMenuItem});
            this.đặtBànToolStripMenuItem.Name = "đặtBànToolStripMenuItem";
            this.đặtBànToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.đặtBànToolStripMenuItem.Text = "Đặt trước";
            // 
            // đặtBànToolStripMenuItem1
            // 
            this.đặtBànToolStripMenuItem1.Name = "đặtBànToolStripMenuItem1";
            this.đặtBànToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.đặtBànToolStripMenuItem1.Text = "Đặt bàn";
            this.đặtBànToolStripMenuItem1.Click += new System.EventHandler(this.đặtBànToolStripMenuItem1_Click);
            // 
            // xemDanhSáchBànĐặtToolStripMenuItem
            // 
            this.xemDanhSáchBànĐặtToolStripMenuItem.Name = "xemDanhSáchBànĐặtToolStripMenuItem";
            this.xemDanhSáchBànĐặtToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.xemDanhSáchBànĐặtToolStripMenuItem.Text = "Xem danh sách";
            this.xemDanhSáchBànĐặtToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.xemDanhSáchBànĐặtToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchBànĐặtToolStripMenuItem_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 518);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phầm mềm quản lý nhà hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTableManager_FormClosed);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpOrderFood.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCountFood)).EndInit();
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnShowfPay;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.NumericUpDown numUDCountFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoAreaAll;
        private System.Windows.Forms.RadioButton rdoAreaVip;
        private System.Windows.Forms.RadioButton rdoAreNormal;
        private System.Windows.Forms.RadioButton rdoTableAll;
        private System.Windows.Forms.RadioButton rdoTableFree;
        private System.Windows.Forms.RadioButton rdoTableActive;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Label lbNameCurrentTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Admin;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_ChangeInfo;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnShowfInfoCustomer;
        private System.Windows.Forms.ToolStripMenuItem đặtBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtBànToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchBànĐặtToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpOrderFood;
        private System.Windows.Forms.ListView listViewFoodOrder;
        private System.Windows.Forms.ColumnHeader ASC;
        private System.Windows.Forms.ColumnHeader listViewColumnDisplayname;
        private System.Windows.Forms.ColumnHeader listViewColumnPrice;
        private System.Windows.Forms.ColumnHeader ListViewColumnCount;
        private System.Windows.Forms.ColumnHeader ListViewColumnTotal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvBookingTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton rdoBookingTable;
    }
}

