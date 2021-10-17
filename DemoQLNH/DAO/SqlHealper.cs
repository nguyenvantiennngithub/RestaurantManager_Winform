using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DemoQLNH
{
    class SqlHealper
    {
        private static SqlHealper instance;

        internal static SqlHealper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlHealper();
                }
                return instance;
            }
            set => instance = value;
        }
    }
}


