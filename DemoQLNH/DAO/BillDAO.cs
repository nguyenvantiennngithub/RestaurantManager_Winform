using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    class BillDAO
    {

        private static BillDAO instance;

        internal static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
            set => instance = value;
        }



        public int getIdBillByIdtableStatus(int idTable, string status)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill result = contex.Bills.Where(bill => bill.status == status && bill.idTable == idTable)
                    .FirstOrDefault();
                if (result != null)
                {
                    return result.id;
                }
                else
                {
                    return -1;
                }
            }
        }

        public Bill getBill(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Bills.Where(bill => bill.idTable == idTable && bill.status == "Chưa tính tiền")
                    .Join(contex.Tables,
                    bill => bill.idTable,
                    table => table.id,
                    (bill, table) => bill).FirstOrDefault();
            }

        }

        public void payBill(int idBill, int moneyInput, int discount)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billQuery = contex.Bills.Where(bill => bill.id == idBill && bill.status == "Chưa tính tiền").First();
                billQuery.dateCheckout = DateTime.Now;
                billQuery.status = "Đã tính tiền";
                billQuery.moneyInput = moneyInput;
                billQuery.discount = discount;
                contex.SaveChanges();
            }
        }


        public void changeIdTableAndListFoodOrder(int idBill, int newIdTable, ListView.ListViewItemCollection listFoodMove)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billDelete = contex.Bills.Where(b => b.id == idBill).FirstOrDefault();
                Bill billInsert = new Bill()
                {
                    status = billDelete.status,
                    sender = billDelete.sender,
                    idTable = newIdTable,
                    idCustomer = billDelete.idCustomer,
                    idBookingTable = billDelete.idBookingTable,
                    isDelete = 0
                };
                //đổi bill mới
                contex.Bills.Add(billInsert);

                //xóa thức ăn trong bill củ
                List<BillDetail> listBillDetailDB = contex.BillDetails.Where(billDetail => billDetail.idBill == idBill).ToList();
                foreach (BillDetail item in listBillDetailDB)
                {
                    contex.BillDetails.Remove(item);
                }

                //thêm thức ăn vào bill mới
                foreach (ListViewItem item in listFoodMove)
                {
                    contex.BillDetails.Add(new BillDetail()
                    {
                        idBill = billInsert.id,
                        displayNameFood = item.SubItems[1].Text,
                        countFood = int.Parse(item.SubItems[3].Text),
                    });
                }
                //xóa bill củ
                contex.Bills.Remove(billDelete);
                contex.SaveChanges();
            }
        }

        public void changeIsDeleteBill(int idBill)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault().isDelete = 1;
                contex.SaveChanges();
            }
        }

        public void changeDateCheckinAndStatusBill(int idBill)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill result = contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault();

                result.dateCheckin = DateTime.Now;
                result.status = "Chưa tính tiền";
                contex.SaveChanges();
            }
        }

        public int getDepositByIdBill(int idBill)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill result = contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault();
                if (result.idBookingTable == null)
                {
                    return 0;
                }
                return contex.BookingTables.Where(bookingTable => bookingTable.id == result.idBookingTable).FirstOrDefault().deposit;
            }
        }
    }
}
