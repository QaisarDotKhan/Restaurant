using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Orders
    {
        public int orderPrice { get; set; }
        public int orderNo { get; set; }
        public string orderDel_Time { get; set; }
        public string orderDate { get; set; }

        public ICollection<Dishes> dishes { get; set; }

    }
}
