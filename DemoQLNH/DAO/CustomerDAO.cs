using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class CustomerDAO
    {

        private static CustomerDAO instance;

        internal static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
            set => instance = value;
        }


        public List<Customer> getListCustomer()
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Customers.Select(customer => customer).ToList();
            }
        }
        public void changeIdCustomerInBill(int idBill, int idCustomer)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault().idCustomer = idCustomer;
                contex.SaveChanges();
            }
        }

        public Customer getCustomerByIdBill(int idBill)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                Bill billTemp = contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault();
                return contex.Customers.Where(customer => customer.id == billTemp.idCustomer).FirstOrDefault();
            }
        }

        public bool checkCustomerExistInBill(int idBill)
        {
            using (var contex = new RestaurantManagerEntities())
            {
                return contex.Bills.Where(bill => bill.id == idBill).FirstOrDefault().idCustomer != null;
            }
        }
    }
}
