
namespace DemoQLNH
{
    partial class fShowListBookingTable
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.start = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.idBill,
            this.idTable,
            this.customerName,
            this.customerPhone,
            this.customerNumber,
            this.time,
            this.show,
            this.Edit,
            this.start,
            this.delete});
            this.dgvMain.Location = new System.Drawing.Point(12, 95);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(1028, 366);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "STT";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 50;
            // 
            // idBill
            // 
            this.idBill.HeaderText = "Mã đặt bàn";
            this.idBill.Name = "idBill";
            this.idBill.ReadOnly = true;
            // 
            // idTable
            // 
            this.idTable.HeaderText = "Mã bàn";
            this.idTable.Name = "idTable";
            this.idTable.ReadOnly = true;
            this.idTable.Width = 75;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Tên khách hàng";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 125;
            // 
            // customerPhone
            // 
            this.customerPhone.HeaderText = "SDT";
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.ReadOnly = true;
            // 
            // customerNumber
            // 
            this.customerNumber.HeaderText = "Số lượng";
            this.customerNumber.Name = "customerNumber";
            this.customerNumber.ReadOnly = true;
            this.customerNumber.Width = 75;
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 150;
            // 
            // show
            // 
            this.show.HeaderText = "Xem";
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.Text = "Xem";
            this.show.UseColumnTextForButtonValue = true;
            this.show.Width = 75;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Sửa";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Sửa";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 75;
            // 
            // start
            // 
            this.start.HeaderText = "Nhập tiệc";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.start.Text = "Nhập tiệc";
            this.start.UseColumnTextForButtonValue = true;
            this.start.Width = 85;
            // 
            // delete
            // 
            this.delete.HeaderText = "Hủy";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Hủy";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đặt bàn";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(821, 467);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(947, 467);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(93, 40);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Thêm bàn";
            this.btnAddTable.UseMnemonic = false;
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // fShowListBookingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 519);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Name = "fShowListBookingTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fBookingTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fShowListBookingTable_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewButtonColumn show;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn start;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}