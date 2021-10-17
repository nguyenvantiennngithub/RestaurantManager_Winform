using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class UserDAO
    {
        private static UserDAO instance;
        internal static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
            set => instance = value;
        }

        public bool checkLogin(string username, string password)
        {
            using (var context = new RestaurantManagerEntities())
            {
                var result = context.Users.Where(user => user.username == username && user.password == password).Count();
                return result > 0;
            }
        }

        public User getInfoUser(string username)
        {
            using (var context = new RestaurantManagerEntities())
            {
                return context.Users.FirstOrDefault(user => user.username == username);
            }
        }

        public void changeInfoUser(string username, string displayName, string password, string phoneNumber)
        {
            using (var context = new RestaurantManagerEntities())
            {
                User userChange = context.Users.FirstOrDefault(u => u.username == username);
                userChange.displayName = displayName;
                userChange.password = password;
                userChange.phoneNumber = phoneNumber;
                context.SaveChanges();
            }
        }



    }
}
