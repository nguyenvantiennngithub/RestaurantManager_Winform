using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    class MoveFoodDAO
    {
        private static MoveFoodDAO instance;

        internal static MoveFoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MoveFoodDAO();
                }
                return instance;
            }
            set => instance = value;
        }



        public void moveAllFoodToFreeTable(int idTableSender, int idTableReceiver)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billSender = contex.Bills.Where(bill => bill.idTable == idTableSender && bill.status == "Chưa tính tiền")
                    .Join(contex.Tables,
                    bill => bill.idTable,
                    table => table.id,
                    (bill, table) => bill).FirstOrDefault();

                Bill billReceiver = BillDAO.Instance.getBill(idTableReceiver);
                var listBillDetailSender = contex.BillDetails.Where(billDetail => billDetail.idBill == billSender.id);

                foreach (BillDetail billDetailItem in listBillDetailSender)
                {
                    billDetailItem.idBill = billReceiver.id;
                }

                contex.Bills.Remove(billSender);
                contex.SaveChanges();
            }
        }
        public void moveSomeFoodToFreeTable(int idTableSender, int idTableReceiver, ListView.ListViewItemCollection listFoodMove)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billSender = BillDAO.Instance.getBill(idTableSender);
                Bill billReceiver = BillDAO.Instance.getBill(idTableReceiver);
                var listBillDetailSender = contex.BillDetails.Where(billDetail => billDetail.idBill == billSender.id);


                foreach (BillDetail billDetailItem in listBillDetailSender)
                {
                    foreach (ListViewItem listViewItem in listFoodMove)
                    {

                        if (billDetailItem.displayNameFood == listViewItem.SubItems[1].Text)
                        {
                            billDetailItem.idBill = billReceiver.id;
                        }
                    }
                }
                contex.SaveChanges();
            }
        }

        public int checkExistFoodOfTwoBill(string displayNameFoodSender, List<BillDetail> listBillReceiver)
        {
            for (int i = 0; i < listBillReceiver.Count; i++)
            {
                if (displayNameFoodSender == listBillReceiver[i].displayNameFood)
                {
                    return i;
                }
            }
            return -1;
        }

        public void moveAllFoodToActiveTable(int idTableSender, int idTableReceiver)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billSender = contex.Bills.Where(bill => bill.idTable == idTableSender && bill.status == "Chưa tính tiền")
                    .Join(contex.Tables,
                    bill => bill.idTable,
                    table => table.id,
                    (bill, table) => bill).FirstOrDefault();

                Bill billReceiver = BillDAO.Instance.getBill(idTableReceiver);
                var listBillDetailSender = contex.BillDetails.Where(billDetail => billDetail.idBill == billSender.id);
                List<BillDetail> listBillDetailReceiver = contex.BillDetails.Where(billDetail => billDetail.idBill == billReceiver.id).ToList();


                foreach (BillDetail billDetailItemSender in listBillDetailSender)
                {
                    int indexOfBillReceiver = checkExistFoodOfTwoBill(billDetailItemSender.displayNameFood, listBillDetailReceiver);
                    if (indexOfBillReceiver == -1)
                    {
                        billDetailItemSender.idBill = billReceiver.id;
                    }
                    else
                    {
                        listBillDetailReceiver[indexOfBillReceiver].countFood = listBillDetailReceiver[indexOfBillReceiver].countFood + billDetailItemSender.countFood;
                        contex.BillDetails.Remove(billDetailItemSender);
                    }
                }
                contex.Bills.Remove(billSender);
                contex.SaveChanges();
            }
        }
        public void moveSomeFoodToActiveTable(int idTableSender, int idTableReceiver, ListView.ListViewItemCollection listFoodMove)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billSender = BillDAO.Instance.getBill(idTableSender);
                Bill billReceiver = BillDAO.Instance.getBill(idTableReceiver);
                var listBillDetailSender = contex.BillDetails.Where(billDetail => billDetail.idBill == billSender.id);
                List<BillDetail> listBillDetailReceiver = contex.BillDetails.Where(billDetail => billDetail.idBill == billReceiver.id).ToList();

                foreach (BillDetail billDetailItemSender in listBillDetailSender)
                {
                    foreach (ListViewItem listViewItem in listFoodMove)
                    {
                        if (billDetailItemSender.displayNameFood == listViewItem.SubItems[1].Text)
                        {
                            int indexOfBillReceiver = checkExistFoodOfTwoBill(billDetailItemSender.displayNameFood, listBillDetailReceiver);
                            if (indexOfBillReceiver == -1)
                            {
                                billDetailItemSender.idBill = billReceiver.id;
                            }
                            else
                            {
                                listBillDetailReceiver[indexOfBillReceiver].countFood = listBillDetailReceiver[indexOfBillReceiver].countFood + billDetailItemSender.countFood;
                                contex.BillDetails.Remove(billDetailItemSender);
                            }
                        }
                    }
                }
                contex.SaveChanges();
            }
        }
    }
}
