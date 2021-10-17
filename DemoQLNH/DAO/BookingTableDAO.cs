using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    class BookingTableDAO
    {
        private static BookingTableDAO instance;

        internal static BookingTableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingTableDAO();
                }
                return instance;
            }
            set => instance = value;
        }

        public int addBookingTableInfo(DateTime time, int deposit, int count, string description)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                BookingTable bookingTable = new BookingTable()
                {
                    time = time,
                    deposit = deposit,
                    count = count,
                    description = description,
                };
                contex.BookingTables.Add(bookingTable);
                contex.SaveChanges();
                return bookingTable.id;
            }
        }


        public void changeBookingTableInfo(int idBill, DateTime time, int deposit, int count, string description)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billTemp = contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault();
                if (billTemp == null) {
                    MessageBox.Show("Lổi changeBookingTableInfo");
                    return;
                } 
                BookingTable booking = contex.BookingTables
                    .Where(bookingTable => bookingTable.id == billTemp.idBookingTable).FirstOrDefault();
                booking.time = time;
                booking.deposit = deposit;
                booking.count = count;
                booking.description = description;
                contex.SaveChanges();
            }
        }
        public List<BookingTableDTO> getListBookingTable()
        {
            using (var contex = new RestaurantManagerEntities())
            {
                //Customer, BookingTable
                return contex.Bills.Where(bill => bill.status == "Đặt trước" && bill.isDelete == 0)
                    .Join(contex.Customers,
                    bill => bill.idCustomer,
                    customer => customer.id,
                    (bill, customer) => new { bill = bill, customer = customer })
                    .Join(contex.BookingTables,
                    bill => bill.bill.idBookingTable,
                    bookingTable => bookingTable.id,
                    (bill, bookingTable) => new BookingTableDTO()
                    {
                        Bill = bill.bill,
                        Customer = bill.customer,
                        BookingTable = bookingTable,
                    }).ToList();
            }
        }

        public List<BookingTableDTO> getListBookingTableByIdTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                //Customer, BookingTable
                return contex.Bills.Where(bill => bill.status == "Đặt trước" && bill.isDelete == 0)
                    .Join(contex.Customers,
                    bill => bill.idCustomer,
                    customer => customer.id,
                    (bill, customer) => new { bill = bill, customer = customer })
                    .Join(contex.BookingTables,
                    bill => bill.bill.idBookingTable,
                    bookingTable => bookingTable.id,
                    (bill, bookingTable) => new BookingTableDTO()
                    {
                        Bill = bill.bill,
                        Customer = bill.customer,
                        BookingTable = bookingTable,
                    }).Where(bill => bill.Bill.idTable == idTable).ToList();
            }
        }

        public BookingTable getTimeOfBookingTableNearstByIdTable(int idTable)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Bills.Where(bill => bill.idTable == idTable)
                    .Join(contex.BookingTables,
                    bill => bill.idBookingTable,
                    bookingTable => bookingTable.id,
                    (bill, bookingTable) => bookingTable)
                        .OrderByDescending(bookingTable => bookingTable.time).FirstOrDefault();
            }
        }
    }
}
