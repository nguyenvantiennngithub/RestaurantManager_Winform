using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    public partial class fPay : Form
    {
        private Bill bill;
        private int idTable;
        private int moneyPay;
        public event EventHandler<EventArgs> refesh;

        public fPay(Bill bill, int idTable, string totalPrice)
        {
            InitializeComponent();
            this.bill = bill;
            this.idTable = idTable;
            this.moneyPay = int.Parse(totalPrice);
            int deposit = BillDAO.Instance.getDepositByIdBill(bill.id);


            lbDateCheckin.Text = bill.dateCheckin.ToString();
            lbIdBill.Text = bill.id.ToString();
            lbNameTable.Text = bill.idTable.ToString();
            txbDeposit.Text = deposit.ToString();

            lbSender.Text = bill.sender;
            txbMoneyPay.Text = (int.Parse(totalPrice) - deposit).ToString();
            
        }

        private void txbMoneyInput_TextChanged(object sender, EventArgs e)
        {
            TextBox txb = sender as TextBox;
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(txb.Text) || txb.Text.Length >= 10)
            {
                if (txb.Text.Length > 0)
                {
                    txb.Text = txb.Text.Remove(txb.Text.Length - 1, 1);
                    txb.SelectionStart = txb.Text.Length;
                }
            }
            else
            {
                txbMoneyReturn.Text = (int.Parse(txb.Text) - int.Parse(txbMoneyPay.Text)).ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            int moneyReturn = int.Parse(txbMoneyReturn.Text);
            if (txbMoneyInput.Text == "")
            {
                MessageBox.Show("Chưa nhập tiền khách đưa, vui lòng nhập tiền khách đưa");
                return;
            }else if (moneyReturn >= 0)
            {
                BillDAO.Instance.payBill(bill.id, int.Parse(txbMoneyInput.Text), int.Parse(numDiscount.Value.ToString()));
                refesh(this, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tiền khách đưa không đủ, vui lòng nhập thêm tiền");
            }
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            double percent = (double)(100 - Decimal.ToInt32(numDiscount.Value)) / 100;
            txbMoneyPay.Text = (Convert.ToDouble(moneyPay) * percent).ToString();
            if (txbMoneyInput.Text != "")
            {
                txbMoneyReturn.Text = (int.Parse(txbMoneyInput.Text) - int.Parse(txbMoneyPay.Text)).ToString();
            }
        }
    }
}
  