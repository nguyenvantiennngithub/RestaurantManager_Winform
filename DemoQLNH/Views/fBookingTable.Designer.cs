
namespace DemoQLNH
{
    partial class fBookingTable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSelectCustomer = new System.Windows.Forms.LinkLabel();
            this.rdoFemaleCustomer = new System.Windows.Forms.RadioButton();
            this.rdoMaleCustomer = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAddressCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimeBooking = new System.Windows.Forms.DateTimePicker();
            this.cbTableBooking = new System.Windows.Forms.ComboBox();
            this.txbNoteBooking = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDepositBooking = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCountBooking = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUDCountFood = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewFoodOrder = new System.Windows.Forms.ListView();
            this.ASC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnDisplayname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewColumnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewColumnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTotalPriceFood = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCountFood)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSelectCustomer);
            this.groupBox1.Controls.Add(this.rdoFemaleCustomer);
            this.groupBox1.Controls.Add(this.rdoMaleCustomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbAddressCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbPhoneCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNameCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbIdCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tinh khách hàng";
            // 
            // lbSelectCustomer
            // 
            this.lbSelectCustomer.AutoSize = true;
            this.lbSelectCustomer.Location = new System.Drawing.Point(208, 40);
            this.lbSelectCustomer.Name = "lbSelectCustomer";
            this.lbSelectCustomer.Size = new System.Drawing.Size(92, 13);
            this.lbSelectCustomer.TabIndex = 11;
            this.lbSelectCustomer.TabStop = true;
            this.lbSelectCustomer.Text = "Chọn khách hàng";
            this.lbSelectCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSelectCustomer_LinkClicked);
            // 
            // rdoFemaleCustomer
            // 
            this.rdoFemaleCustomer.AutoSize = true;
            this.rdoFemaleCustomer.Enabled = false;
            this.rdoFemaleCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemaleCustomer.Location = new System.Drawing.Point(187, 176);
            this.rdoFemaleCustomer.Name = "rdoFemaleCustomer";
            this.rdoFemaleCustomer.Size = new System.Drawing.Size(44, 21);
            this.rdoFemaleCustomer.TabIndex = 10;
            this.rdoFemaleCustomer.Text = "Nữ";
            this.rdoFemaleCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoMaleCustomer
            // 
            this.rdoMaleCustomer.AutoSize = true;
            this.rdoMaleCustomer.Checked = true;
            this.rdoMaleCustomer.Enabled = false;
            this.rdoMaleCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaleCustomer.Location = new System.Drawing.Point(117, 176);
            this.rdoMaleCustomer.Name = "rdoMaleCustomer";
            this.rdoMaleCustomer.Size = new System.Drawing.Size(55, 21);
            this.rdoMaleCustomer.TabIndex = 9;
            this.rdoMaleCustomer.TabStop = true;
            this.rdoMaleCustomer.Text = "Nam";
            this.rdoMaleCustomer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính";
            // 
            // txbAddressCustomer
            // 
            this.txbAddressCustomer.Enabled = false;
            this.txbAddressCustomer.Location = new System.Drawing.Point(115, 141);
            this.txbAddressCustomer.Name = "txbAddressCustomer";
            this.txbAddressCustomer.Size = new System.Drawing.Size(193, 20);
            this.txbAddressCustomer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txbPhoneCustomer
            // 
            this.txbPhoneCustomer.Enabled = false;
            this.txbPhoneCustomer.Location = new System.Drawing.Point(115, 105);
            this.txbPhoneCustomer.Name = "txbPhoneCustomer";
            this.txbPhoneCustomer.Size = new System.Drawing.Size(193, 20);
            this.txbPhoneCustomer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // txbNameCustomer
            // 
            this.txbNameCustomer.Enabled = false;
            this.txbNameCustomer.Location = new System.Drawing.Point(115, 69);
            this.txbNameCustomer.Name = "txbNameCustomer";
            this.txbNameCustomer.Size = new System.Drawing.Size(193, 20);
            this.txbNameCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txbIdCustomer
            // 
            this.txbIdCustomer.Enabled = false;
            this.txbIdCustomer.Location = new System.Drawing.Point(115, 35);
            this.txbIdCustomer.Name = "txbIdCustomer";
            this.txbIdCustomer.Size = new System.Drawing.Size(87, 20);
            this.txbIdCustomer.TabIndex = 1;
            this.txbIdCustomer.Leave += new System.EventHandler(this.txbIdCustomer_Leave);
            this.txbIdCustomer.MouseLeave += new System.EventHandler(this.txbIdCustomer_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimeBooking);
            this.groupBox2.Controls.Add(this.cbTableBooking);
            this.groupBox2.Controls.Add(this.txbNoteBooking);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txbDepositBooking);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbCountBooking);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đặt bàn";
            // 
            // dateTimeBooking
            // 
            this.dateTimeBooking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBooking.Location = new System.Drawing.Point(117, 39);
            this.dateTimeBooking.MinDate = new System.DateTime(2021, 10, 15, 0, 0, 0, 0);
            this.dateTimeBooking.Name = "dateTimeBooking";
            this.dateTimeBooking.Size = new System.Drawing.Size(191, 20);
            this.dateTimeBooking.TabIndex = 19;
            // 
            // cbTableBooking
            // 
            this.cbTableBooking.FormattingEnabled = true;
            this.cbTableBooking.Location = new System.Drawing.Point(115, 69);
            this.cbTableBooking.Name = "cbTableBooking";
            this.cbTableBooking.Size = new System.Drawing.Size(193, 21);
            this.cbTableBooking.TabIndex = 18;
            // 
            // txbNoteBooking
            // 
            this.txbNoteBooking.Location = new System.Drawing.Point(115, 176);
            this.txbNoteBooking.Name = "txbNoteBooking";
            this.txbNoteBooking.Size = new System.Drawing.Size(193, 63);
            this.txbNoteBooking.TabIndex = 17;
            this.txbNoteBooking.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ghi chú";
            // 
            // txbDepositBooking
            // 
            this.txbDepositBooking.Location = new System.Drawing.Point(117, 141);
            this.txbDepositBooking.Name = "txbDepositBooking";
            this.txbDepositBooking.Size = new System.Drawing.Size(193, 20);
            this.txbDepositBooking.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiền cọc";
            // 
            // txbCountBooking
            // 
            this.txbCountBooking.Location = new System.Drawing.Point(117, 106);
            this.txbCountBooking.Name = "txbCountBooking";
            this.txbCountBooking.Size = new System.Drawing.Size(193, 20);
            this.txbCountBooking.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số lượng khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên bàn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.numUDCountFood);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbFoodCategory);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 68);
            this.panel1.TabIndex = 5;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Món ăn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Loại món ăn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewFoodOrder);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(361, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 423);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin món ăn";
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
            this.listViewFoodOrder.Location = new System.Drawing.Point(6, 93);
            this.listViewFoodOrder.Name = "listViewFoodOrder";
            this.listViewFoodOrder.Size = new System.Drawing.Size(443, 322);
            this.listViewFoodOrder.TabIndex = 7;
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(714, 441);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 37);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Lưu thông tin";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(714, 484);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(363, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tổng tiền món ăn: ";
            // 
            // lbTotalPriceFood
            // 
            this.lbTotalPriceFood.AutoSize = true;
            this.lbTotalPriceFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPriceFood.Location = new System.Drawing.Point(500, 438);
            this.lbTotalPriceFood.Name = "lbTotalPriceFood";
            this.lbTotalPriceFood.Size = new System.Drawing.Size(18, 20);
            this.lbTotalPriceFood.TabIndex = 11;
            this.lbTotalPriceFood.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(363, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Giá món ăn tính theo khu thường";
            // 
            // fBookingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 537);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbTotalPriceFood);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fBookingTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBookingTable";
            this.Load += new System.EventHandler(this.fBookingTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCountFood)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFemaleCustomer;
        private System.Windows.Forms.RadioButton rdoMaleCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAddressCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPhoneCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNameCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIdCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txbNoteBooking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDepositBooking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCountBooking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numUDCountFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewFoodOrder;
        private System.Windows.Forms.ColumnHeader ASC;
        private System.Windows.Forms.ColumnHeader listViewColumnDisplayname;
        private System.Windows.Forms.ColumnHeader listViewColumnPrice;
        private System.Windows.Forms.ColumnHeader ListViewColumnCount;
        private System.Windows.Forms.ColumnHeader ListViewColumnTotal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalPriceFood;
        private System.Windows.Forms.DateTimePicker dateTimeBooking;
        private System.Windows.Forms.LinkLabel lbSelectCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTableBooking;
    }
}