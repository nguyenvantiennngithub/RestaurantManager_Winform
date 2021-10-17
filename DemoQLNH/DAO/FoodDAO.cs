using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class FoodDAO
    {

        private static FoodDAO instance;

        internal static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
            set => instance = value;
        }


        public List<FoodGroupByDTO> getListFoodGroupByDisplayNameCategory()
        {
            using (var context = new RestaurantManagerEntities())
            {
                return context.Foods.GroupBy(food => food.displayNameFoodCategory)
                    .Select(food => new FoodGroupByDTO
                    {
                        Key = food.Key,
                        ListFood = food.ToList()
                    }).ToList();
            }
        }
        public List<Food> getListFood()
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Foods.Select(food => food).ToList();
            }
        }




        public List<ListFoodOrderDTO> getListFoodOrderByIdBill(int idBill)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Bills.Where(bill => bill.id == idBill)
                    .Join(contex.BillDetails,
                    bill => bill.id,
                    billDetail => billDetail.idBill,
                    ((bill, billDetail) => new
                    {
                        idTable = bill.idTable,
                        displayNameFood = billDetail.displayNameFood,
                        count = billDetail.countFood,
                    })).Join(contex.Foods,
                        bill => bill.displayNameFood,
                        food => food.displayName,
                        (bill, food) => new ListFoodOrderDTO
                        {
                            IdTable = bill.idTable,
                            DisplayNameFood = bill.displayNameFood,
                            Count = (int)bill.count,
                            PriceVip = food.priceVip,
                            PriceNormal = food.priceNormal,
                        }).ToList();
            }
        }


        public List<ListFoodOrderDTO> getListFoodOrderByIdTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Bills.Where(bill => bill.status == "Chưa tính tiền")
                    .Join(contex.BillDetails,
                    bill => bill.id,
                    billDetail => billDetail.idBill,
                    ((bill, billDetail) => new
                    {
                        idTable = bill.idTable,
                        displayNameFood = billDetail.displayNameFood,
                        count = billDetail.countFood,
                    })).Join(contex.Foods,
                        bill => bill.displayNameFood,
                        food => food.displayName,
                        (bill, food) => new ListFoodOrderDTO
                        {
                            IdTable = bill.idTable,
                            DisplayNameFood = bill.displayNameFood,
                            Count = (int)bill.count,
                            PriceVip = food.priceVip,
                            PriceNormal = food.priceNormal,
                        }).Where(bill => bill.IdTable == idTable).ToList();
            }
        }


    }
}
