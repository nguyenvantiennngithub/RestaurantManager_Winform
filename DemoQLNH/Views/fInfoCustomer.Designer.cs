
namespace DemoQLNH
{
    partial class fInfoCustomer
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.showFormInfoCustumer = new System.Windows.Forms.LinkLabel();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên ";
            // 
            // txbName
            // 
            this.txbName.Enabled = false;
            this.txbName.Location = new System.Drawing.Point(146, 79);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(216, 20);
            this.txbName.TabIndex = 1;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Enabled = false;
            this.txbPhoneNumber.Location = new System.Drawing.Point(146, 116);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(216, 20);
            this.txbPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại ";
            // 
            // txbAddress
            // 
            this.txbAddress.Enabled = false;
            this.txbAddress.Location = new System.Drawing.Point(146, 155);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(216, 20);
            this.txbAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Enabled = false;
            this.rdoMale.Location = new System.Drawing.Point(146, 192);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 17);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Enabled = false;
            this.rdoFemale.Location = new System.Drawing.Point(223, 192);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(39, 17);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(287, 238);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Cập nhật";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // showFormInfoCustumer
            // 
            this.showFormInfoCustumer.AutoSize = true;
            this.showFormInfoCustumer.Location = new System.Drawing.Point(91, 243);
            this.showFormInfoCustumer.Name = "showFormInfoCustumer";
            this.showFormInfoCustumer.Size = new System.Drawing.Size(92, 13);
            this.showFormInfoCustumer.TabIndex = 14;
            this.showFormInfoCustumer.TabStop = true;
            this.showFormInfoCustumer.Text = "Danh sách đã lưu";
            this.showFormInfoCustumer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showFormInfoCustumer_LinkClicked);
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(146, 42);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(216, 20);
            this.txbId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã khách ";
            // 
            // fInfoCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 273);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showFormInfoCustumer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "fInfoCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInfoCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel showFormInfoCustumer;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label5;
    }
}