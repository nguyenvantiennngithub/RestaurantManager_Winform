using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class BillDetailDAO
    {

        private static BillDetailDAO instance;

        internal static BillDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDetailDAO();
                }
                return instance;
            }
            set => instance = value;
        }





        public void removeRowBillDetail(int idTable, string displayNameFood)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                BillDetail billDelete = contex.Bills.Where(bill => bill.idTable == idTable && bill.status == "Chưa tính tiền")
                    .Join(contex.BillDetails,
                    bill => bill.id,
                    billDetail => billDetail.idBill,
                    (bill, billDetail) => billDetail).FirstOrDefault(billDetail => billDetail.displayNameFood == displayNameFood);
                contex.BillDetails.Remove(billDelete);
                contex.SaveChanges();
            }
        }

        public void changeCountFoodOrderBillDetail(int idTable, string displayNameFood, int valueChange)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                contex.Bills.Where(bill => bill.idTable == idTable && bill.status == "Chưa tính tiền")
                     .Join(contex.BillDetails,
                     bill => bill.id,
                     billDetail => billDetail.idBill,
                     (bill, billDetail) => billDetail).FirstOrDefault(billDetail => billDetail.displayNameFood == displayNameFood).countFood = valueChange;
                contex.SaveChanges();
            }
        }
        public void addRowBillDetail(int idTable, string displayNameFood, int countOfFood)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                int idBillQuery = contex.Bills.Where(bill => bill.idTable == idTable && bill.status == "Chưa tính tiền").Select(bill => bill.id).FirstOrDefault();

                contex.BillDetails.Add(new BillDetail
                {
                    idBill = idBillQuery,
                    displayNameFood = displayNameFood,
                    countFood = countOfFood,
                });

                contex.SaveChanges();
            }
        }

        public void addBillDetailByIdBill(BillDetail billDetail)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                contex.BillDetails.Add(billDetail);
                contex.SaveChanges();
            }
        }
    }
}
