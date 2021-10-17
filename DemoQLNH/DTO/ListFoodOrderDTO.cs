using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class ListFoodOrderDTO
    {
        private string displayNameFood;
        private int count;
        private int priceVip;
        private int priceNormal;
        private int idTable;

      
        public ListFoodOrderDTO()
        {
        }

        public ListFoodOrderDTO(string displayNameFood, int count, int priceNormal, int priceVip, int idTable)
        {
            this.DisplayNameFood = displayNameFood;
            this.Count = count;
            this.PriceNormal = priceNormal;
            this.PriceVip = priceVip;
            this.IdTable = idTable;
        }

        public string DisplayNameFood { get => displayNameFood; set => displayNameFood = value; }
        public int Count { get => count; set => count = value; }
        public int PriceVip { get => priceVip; set => priceVip = value; }
        public int PriceNormal { get => priceNormal; set => priceNormal = value; }
        public int IdTable { get => idTable; set => idTable = value; }
    }
}
