using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class FoodGroupByDTO
    {
        private string key;
        private List<Food> listFood;

        public FoodGroupByDTO(string key, List<Food> listFood)
        {
            this.Key = key;
            this.ListFood = listFood;
        }

        public FoodGroupByDTO()
        {
        }

        public string Key { get => key; set => key = value; }
        public List<Food> ListFood { get => listFood; set => listFood = value; }
    }
}
