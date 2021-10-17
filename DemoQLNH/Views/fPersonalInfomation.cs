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
    public partial class fPersonalInfomation : Form
    {
        public fPersonalInfomation(User user)
        {
            InitializeComponent();
            txbDisplayName.Text = user.displayName;
            txbPassword.Text = user.password;
            txbPhone.Text = user.phoneNumber.ToString();
            txbUsername.Text = user.username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbDisplayName.Text.Trim() != "" && txbDisplayName.Text.Trim() != "" && txbPassword.Text.Trim() != "" && txbPhone.Text.Trim() != "")
            {
                UserDAO.Instance.changeInfoUser(txbUsername.Text, txbDisplayName.Text, txbPassword.Text, txbPhone.Text);
                MessageBox.Show("Cập nhật thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin, vui lồng nhập đủ thông tin");
            }
        }
    }
}
