using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{

    public class BookingTableDTO
    {
        private Customer customer;
        private BookingTable bookingTable;
        private Bill bill;

        public BookingTableDTO()
        {
        }

        public BookingTableDTO(Customer customer, BookingTable bookingTable, Bill bill)
        {
            this.Customer = customer;
            this.BookingTable = bookingTable;
            this.Bill = bill;
        }

        public Customer Customer { get => customer; set => customer = value; }
        public BookingTable BookingTable { get => bookingTable; set => bookingTable = value; }
        public Bill Bill { get => bill; set => bill = value; }
    }
}
