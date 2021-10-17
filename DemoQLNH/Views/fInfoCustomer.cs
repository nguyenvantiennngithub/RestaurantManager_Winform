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
    public partial class fInfoCustomer : Form
    {
        private int idBill;
        public fInfoCustomer(int idBill)
        {
            this.idBill = idBill;
            InitializeComponent();
            loadsData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadsData()
        {
            Customer customer = CustomerDAO.Instance.getCustomerByIdBill(idBill);
            if (customer != null)
            {
                txbId.Text = customer.id.ToString();
                txbName.Text = customer.displayName;
                txbAddress.Text = customer.address;
                txbPhoneNumber.Text = customer.phoneNumber;
                rdoFemale.Checked = customer.gender == "Nữ";
                rdoMale.Checked = customer.gender == "Nam";
            }
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txbName.Text != "" && txbPhoneNumber.Text != "")
            {

                CustomerDAO.Instance.changeIdCustomerInBill(idBill, int.Parse(txbId.Text));
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần phải chọn khách hàng");
            }
        }

        private void showFormInfoCustumer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (fShowListInfoCustomer form = new fShowListInfoCustomer())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txbId.Text = form.IdCustomer;
                    txbName.Text = form.DisplayName;
                    txbAddress.Text = form.Address;
                    txbPhoneNumber.Text = form.Phone;
                    rdoFemale.Checked = form.Gender == "Nữ";
                    rdoMale.Checked = form.Gender == "Nam";
                }
            }
        }
    }
}
