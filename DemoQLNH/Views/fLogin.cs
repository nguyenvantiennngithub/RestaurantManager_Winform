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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (UserDAO.Instance.checkLogin(txbUsername.Text, txbPassword.Text))
            {
                fTableManager fTable = new fTableManager(txbUsername.Text);
                this.Hide();
                fTable.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoảng hoặc mật khẩu", "Thông báo");
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !(sender as CheckBox).Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
