
namespace DemoQLNH
{
    partial class fPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbDateCheckin = new System.Windows.Forms.Label();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.lbSender = new System.Windows.Forms.Label();
            this.txbMoneyInput = new System.Windows.Forms.TextBox();
            this.txbMoneyPay = new System.Windows.Forms.TextBox();
            this.txbMoneyReturn = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thanh toán hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên bàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên người lập ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiền nhận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiền phải trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiền thối ";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(221, 382);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbDateCheckin
            // 
            this.lbDateCheckin.AutoSize = true;
            this.lbDateCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateCheckin.Location = new System.Drawing.Point(147, 72);
            this.lbDateCheckin.Name = "lbDateCheckin";
            this.lbDateCheckin.Size = new System.Drawing.Size(64, 17);
            this.lbDateCheckin.TabIndex = 9;
            this.lbDateCheckin.Text = "Ngày lập";
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBill.Location = new System.Drawing.Point(147, 107);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(64, 17);
            this.lbIdBill.TabIndex = 10;
            this.lbIdBill.Text = "Ngày lập";
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.Location = new System.Drawing.Point(147, 142);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(64, 17);
            this.lbNameTable.TabIndex = 11;
            this.lbNameTable.Text = "Ngày lập";
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSender.Location = new System.Drawing.Point(147, 177);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(64, 17);
            this.lbSender.TabIndex = 12;
            this.lbSender.Text = "Ngày lập";
            // 
            // txbMoneyInput
            // 
            this.txbMoneyInput.Location = new System.Drawing.Point(150, 211);
            this.txbMoneyInput.Name = "txbMoneyInput";
            this.txbMoneyInput.Size = new System.Drawing.Size(146, 20);
            this.txbMoneyInput.TabIndex = 0;
            this.txbMoneyInput.TextChanged += new System.EventHandler(this.txbMoneyInput_TextChanged);
            // 
            // txbMoneyPay
            // 
            this.txbMoneyPay.Enabled = false;
            this.txbMoneyPay.Location = new System.Drawing.Point(150, 315);
            this.txbMoneyPay.Name = "txbMoneyPay";
            this.txbMoneyPay.Size = new System.Drawing.Size(146, 20);
            this.txbMoneyPay.TabIndex = 14;
            // 
            // txbMoneyReturn
            // 
            this.txbMoneyReturn.Enabled = false;
            this.txbMoneyReturn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbMoneyReturn.Location = new System.Drawing.Point(150, 351);
            this.txbMoneyReturn.Name = "txbMoneyReturn";
            this.txbMoneyReturn.Size = new System.Drawing.Size(146, 20);
            this.txbMoneyReturn.TabIndex = 15;
            this.txbMoneyReturn.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(136, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Giảm giá (%)";
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(150, 247);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(146, 20);
            this.numDiscount.TabIndex = 19;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // txbDeposit
            // 
            this.txbDeposit.Enabled = false;
            this.txbDeposit.Location = new System.Drawing.Point(150, 280);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(146, 20);
            this.txbDeposit.TabIndex = 21;
            this.txbDeposit.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tiền đặt cọc";
            // 
            // fPay
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 417);
            this.Controls.Add(this.txbDeposit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbMoneyReturn);
            this.Controls.Add(this.txbMoneyPay);
            this.Controls.Add(this.txbMoneyInput);
            this.Controls.Add(this.lbSender);
            this.Controls.Add(this.lbNameTable);
            this.Controls.Add(this.lbIdBill);
            this.Controls.Add(this.lbDateCheckin);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPay";
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lbDateCheckin;
        private System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.Label lbNameTable;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.TextBox txbMoneyInput;
        private System.Windows.Forms.TextBox txbMoneyPay;
        private System.Windows.Forms.TextBox txbMoneyReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.Label label10;
    }
}