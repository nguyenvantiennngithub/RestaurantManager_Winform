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
    public partial class fCheckPassword : Form
    {
        private string username;
        public fCheckPassword(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text.Trim() != "")
            {
                if (UserDAO.Instance.checkLogin(username, txbPassword.Text))
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu, vui lòng nhập lại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu, vui lòng nhập mật khẩu"); ;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Hide();
        }
    }
}
