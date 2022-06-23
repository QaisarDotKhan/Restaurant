using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Models
{
    public class Branches
    {
        public int branchNo { get; set; }
        public string branchCityName { get; set; }
        public string branchTelephone { get; set; }
        public int branchTotalemployees { get; set; }
        public Owner owner { get; set; }

        public ICollection<Dishes> dishes { get; set; }
        public ICollection<Employee> employee { get; set; }
    }
}
