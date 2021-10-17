
namespace DemoQLNH
{
    partial class fMoveTable
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
            this.cbSender = new System.Windows.Forms.ComboBox();
            this.lvSender = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvReceiver = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbReceiver = new System.Windows.Forms.ComboBox();
            this.btnSender = new System.Windows.Forms.Button();
            this.btnSenderAll = new System.Windows.Forms.Button();
            this.btnReceiver = new System.Windows.Forms.Button();
            this.btnReceiverAll = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSender = new System.Windows.Forms.Panel();
            this.pnlReceiver = new System.Windows.Forms.Panel();
            this.pnlSender.SuspendLayout();
            this.pnlReceiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSender
            // 
            this.cbSender.FormattingEnabled = true;
            this.cbSender.Location = new System.Drawing.Point(0, 50);
            this.cbSender.Name = "cbSender";
            this.cbSender.Size = new System.Drawing.Size(114, 21);
            this.cbSender.TabIndex = 0;
            // 
            // lvSender
            // 
            this.lvSender.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSender.HideSelection = false;
            this.lvSender.Location = new System.Drawing.Point(-1, 106);
            this.lvSender.Name = "lvSender";
            this.lvSender.Size = new System.Drawing.Size(288, 309);
            this.lvSender.TabIndex = 2;
            this.lvSender.UseCompatibleStateImageBehavior = false;
            this.lvSender.View = System.Windows.Forms.View.Details;
            this.lvSender.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvSender_ColumnClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "int";
            this.columnHeader5.Text = "STT";
            this.columnHeader5.Width = 36;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "string";
            this.columnHeader6.Text = "Tên món";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "int";
            this.columnHeader7.Text = "Đơn giá";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Tag = "int";
            this.columnHeader8.Text = "Số lượng";
            this.columnHeader8.Width = 57;
            // 
            // lvReceiver
            // 
            this.lvReceiver.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvReceiver.HideSelection = false;
            this.lvReceiver.Location = new System.Drawing.Point(7, 100);
            this.lvReceiver.Name = "lvReceiver";
            this.lvReceiver.Size = new System.Drawing.Size(288, 309);
            this.lvReceiver.TabIndex = 4;
            this.lvReceiver.UseCompatibleStateImageBehavior = false;
            this.lvReceiver.View = System.Windows.Forms.View.Details;
            this.lvReceiver.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvReceiver_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "int";
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "string";
            this.columnHeader2.Text = "Tên món";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "int";
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "int";
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 55;
            // 
            // cbReceiver
            // 
            this.cbReceiver.FormattingEnabled = true;
            this.cbReceiver.Location = new System.Drawing.Point(7, 44);
            this.cbReceiver.Name = "cbReceiver";
            this.cbReceiver.Size = new System.Drawing.Size(114, 21);
            this.cbReceiver.TabIndex = 3;
            this.cbReceiver.SelectedIndexChanged += new System.EventHandler(this.cbReceiver_SelectedIndexChanged);
            // 
            // btnSender
            // 
            this.btnSender.Location = new System.Drawing.Point(354, 129);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(90, 35);
            this.btnSender.TabIndex = 6;
            this.btnSender.Text = ">";
            this.btnSender.UseVisualStyleBackColor = true;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // btnSenderAll
            // 
            this.btnSenderAll.Location = new System.Drawing.Point(354, 170);
            this.btnSenderAll.Name = "btnSenderAll";
            this.btnSenderAll.Size = new System.Drawing.Size(90, 35);
            this.btnSenderAll.TabIndex = 7;
            this.btnSenderAll.Text = ">>";
            this.btnSenderAll.UseVisualStyleBackColor = true;
            this.btnSenderAll.Click += new System.EventHandler(this.btnSenderAll_Click);
            // 
            // btnReceiver
            // 
            this.btnReceiver.Location = new System.Drawing.Point(354, 297);
            this.btnReceiver.Name = "btnReceiver";
            this.btnReceiver.Size = new System.Drawing.Size(90, 35);
            this.btnReceiver.TabIndex = 8;
            this.btnReceiver.Text = "<";
            this.btnReceiver.UseVisualStyleBackColor = true;
            this.btnReceiver.Click += new System.EventHandler(this.btnReceiver_Click);
            // 
            // btnReceiverAll
            // 
            this.btnReceiverAll.Location = new System.Drawing.Point(354, 338);
            this.btnReceiverAll.Name = "btnReceiverAll";
            this.btnReceiverAll.Size = new System.Drawing.Size(90, 35);
            this.btnReceiverAll.TabIndex = 9;
            this.btnReceiverAll.Text = "<<";
            this.btnReceiverAll.UseVisualStyleBackColor = true;
            this.btnReceiverAll.Click += new System.EventHandler(this.btnReceiverAll_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(405, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 35);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Chuyển bàn";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(309, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bàn chuyển";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bàn nhận";
            // 
            // pnlSender
            // 
            this.pnlSender.Controls.Add(this.label1);
            this.pnlSender.Controls.Add(this.cbSender);
            this.pnlSender.Controls.Add(this.lvSender);
            this.pnlSender.Location = new System.Drawing.Point(12, 23);
            this.pnlSender.Name = "pnlSender";
            this.pnlSender.Size = new System.Drawing.Size(290, 415);
            this.pnlSender.TabIndex = 14;
            // 
            // pnlReceiver
            // 
            this.pnlReceiver.Controls.Add(this.label2);
            this.pnlReceiver.Controls.Add(this.cbReceiver);
            this.pnlReceiver.Controls.Add(this.lvReceiver);
            this.pnlReceiver.Location = new System.Drawing.Point(494, 29);
            this.pnlReceiver.Name = "pnlReceiver";
            this.pnlReceiver.Size = new System.Drawing.Size(301, 409);
            this.pnlReceiver.TabIndex = 15;
            // 
            // fMoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlReceiver);
            this.Controls.Add(this.pnlSender);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReceiverAll);
            this.Controls.Add(this.btnReceiver);
            this.Controls.Add(this.btnSenderAll);
            this.Controls.Add(this.btnSender);
            this.Name = "fMoveTable";
            this.Text = "fMoveTable";
            this.Load += new System.EventHandler(this.fMoveTable_Load);
            this.pnlSender.ResumeLayout(false);
            this.pnlSender.PerformLayout();
            this.pnlReceiver.ResumeLayout(false);
            this.pnlReceiver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSender;
        private System.Windows.Forms.ListView lvSender;
        private System.Windows.Forms.ListView lvReceiver;
        private System.Windows.Forms.ComboBox cbReceiver;
        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.Button btnSenderAll;
        private System.Windows.Forms.Button btnReceiver;
        private System.Windows.Forms.Button btnReceiverAll;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnlSender;
        private System.Windows.Forms.Panel pnlReceiver;
    }
}