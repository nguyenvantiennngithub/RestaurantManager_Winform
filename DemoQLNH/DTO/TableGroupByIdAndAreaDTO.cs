using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class TableGroupByIdAndAreaDTO
    {
        private int id;
        private string displayNameArea;

        public TableGroupByIdAndAreaDTO(int id, string displayNameArea)
        {
            this.Id = id;
            this.DisplayNameArea = displayNameArea;
        }
        public TableGroupByIdAndAreaDTO()
        {
        }
        public int Id { get => id; set => id = value; }
        public string DisplayNameArea { get => displayNameArea; set => displayNameArea = value; }
    }
}
