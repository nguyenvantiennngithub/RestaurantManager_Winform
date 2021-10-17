using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class TableDAO
    {
        private static TableDAO instance;
        internal static TableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<Table> getTables()
        {
            using (var context = new RestaurantManagerEntities())
            {
                return context.Tables.Join(
                    context.Areas,
                    table => table.displayNameArea,
                    area => area.displayName,
                    (table, area) => table).ToList();
            }
        }

        public List<Table> getTablesActive()
        {
            using (var context = new RestaurantManagerEntities())
            {
                return context.Bills.Where(bill => bill.status == "Chưa tính tiền")
                    .Join(context.Tables,
                    bill => bill.idTable,
                    table => table.id,
                    (bill, table) => table).ToList();
            }
        }
        public Table getInfoTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Tables.Where(table => table.id == idTable).FirstOrDefault();
            }
        }
        //true active
        //false free
        public bool getStatusTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill currentBill = contex.Bills.Where(bill => bill.idTable == idTable && bill.status == "Chưa tính tiền").FirstOrDefault();
                if (currentBill != null)
                {
                    return true;
                }
                return false;
            }
        }

        //true active
        //false free
        public string getAreaTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Tables.Where(table => table.id == idTable)
                    .Join(contex.Areas,
                    table => table.displayNameArea,
                    area => area.displayName,
                    (table, area) => area).Select(area => area.displayName).FirstOrDefault();
            }
        }

        public int addBillAndChangeStatusTable(int idTable, string username, string status, DateTime? time, int? idCustomer, int? idBookingTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill bill = new Bill()
                {
                    idTable = idTable,
                    sender = username,
                    dateCheckin = time,
                    status = status,
                    idCustomer = idCustomer,
                    idBookingTable = idBookingTable,
                    isDelete = 0
                };
                contex.Bills.Add(bill);
                contex.SaveChanges();
                return bill.id;
            }
        }


        public List<TableGroupByIdAndAreaDTO> getListTableHasBooking()
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Tables
                    .Join(contex.Bills,
                    table => table.id,
                    bill => bill.idTable,
                    (table, bill) => new { table = table, bill = bill })
                    .Where(bill => bill.bill.isDelete == 0 && bill.bill.status == "Đặt trước")
                    .GroupBy(bill => new
                    {
                        Id = bill.table.id,
                        DisplayNameArea = bill.table.displayNameArea,
                    }).Select(bill => new TableGroupByIdAndAreaDTO()
                    {
                        Id = bill.Key.Id,
                        DisplayNameArea = bill.Key.DisplayNameArea,
                    }).ToList();
            }
        }

        public bool checkTableActiveByIdTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Bills.Where(bill => bill.id == idTable && bill.isDelete == 0 && bill.status == "Chưa tính tiền")
                    .ToList().Count > 0;
            }
        }
    }
}
