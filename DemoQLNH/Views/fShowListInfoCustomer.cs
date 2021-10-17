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
    public partial class fShowListInfoCustomer : Form
    {
        private string idCustomer;
        private string alias;
        private string displayName;
        private string phone;
        private string address;
        private string gender;
        public fShowListInfoCustomer()
        {
            InitializeComponent();
            load();
            listView1.FullRowSelect = true;
        }

        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string Alias { get => alias; set => alias = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }

        public void load()
        {
            List<Customer> listCustomer = CustomerDAO.Instance.getListCustomer();
            foreach (Customer item in listCustomer)
            {
                ListViewItem lvi = new ListViewItem(item.id.ToString());
                lvi.SubItems.Add(item.displayName);
                lvi.SubItems.Add(item.phoneNumber);
                lvi.SubItems.Add(item.address);
                lvi.SubItems.Add(item.gender);
                listView1.Items.Add(lvi); 
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            this.IdCustomer = lvi.SubItems[0].Text;
            this.DisplayName = lvi.SubItems[1].Text;
            this.Phone = lvi.SubItems[2].Text;
            this.Address = lvi.SubItems[3].Text;
            this.Gender = lvi.SubItems[4].Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
