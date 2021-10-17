using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    class ListViewItemComparerController : IComparer
    {
        private int col;
        private string variableType;
        private string sortType;

        public ListViewItemComparerController()
        {
            col = 0;
        }
        public ListViewItemComparerController(int column, string variableType, string sortType)
        {
            col = column;
            this.variableType = variableType;
            this.sortType = sortType;
        }
        public int Compare(object x, object y)
        {
            ListViewItem lv1 = x as ListViewItem;
            ListViewItem lv2 = y as ListViewItem;
            int result = 0;
            if (variableType == "int")
            {
                result = int.Parse(lv1.SubItems[col].Text) - int.Parse(lv2.SubItems[col].Text);
            }
            else if (variableType == "string")
            {
                result = String.Compare(lv1.SubItems[col].Text, lv2.SubItems[col].Text);
            }else if (variableType == "time")
            {
                var formats = new[]
                {
                    "dd/MM/yyyy",
                    "dd/MM/yyyy HH:mm",
                    "HH:mm dd/MM/yyyy",
                    "dd/MM/yyyy HH:mm",
                    "dd/MM/yyyy HH:mm:ss",
                    "dd/MM/yyyy HH:mm:ss",
                    "dd/MM/yyyy hh:mm:ss",
                };
                long time1 = DateTime.ParseExact(lv1.SubItems[col].Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None).ToFileTimeUtc(); ;
                long time2 = DateTime.ParseExact(lv2.SubItems[col].Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None).ToFileTimeUtc(); ;
                if (time1 - time2 > 0) result = 1;
                else if (time1 - time2 < 0) result = -1;
                else result = 0;
            }

            if (sortType == "DESC")
            {
                result = -result;
            }
            return result;
        }
    }
}
