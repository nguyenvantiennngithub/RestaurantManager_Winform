using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLNH
{
    class SortListViewController
    {
        private string variableType;
        private string sortType;
        private ListView listView;
        private int column;
        public void sort(int col)
        {
            VariableType = ListView.Columns[col].Tag.ToString();
            if (col == Column)
            {
                if (sortType == "ASC") sortType = "DESC";
                else sortType = "ASC";
            }
            else
            {
                sortType = "ASC";
            }

            listView.ListViewItemSorter = new ListViewItemComparerController(col, VariableType, sortType);
            Column = col;
            
        }

        public SortListViewController(ListView listView)
        {
            this.listView = listView;
            column = -1;
            sortType = "ASC";
        }

        public ListView ListView { get => listView; set => listView = value; }
        public int Column { get => column; set => column = value; }
        public string SortType { get => sortType; set => sortType = value; }
        public string VariableType { get => variableType; set => variableType = value; }
    }
}
