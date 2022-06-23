using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Dishes
    {
        public string DishesName { get; set; }
        public string DishIngredient { get; set; }
        public int DishPrice { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<Branches> Branches { get; set; }
    }
}
