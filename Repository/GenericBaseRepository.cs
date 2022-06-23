using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repository
{
    public class GenericBaseRepository<T>: IGenericRepository<T> where T : class
    {
        List<T> l = new List<T>();
        public void Delete(T variable)
        {
            l.Remove(variable);
        }

        public List<T> Get()
        {
            return l;
        }

        public void Insert(List<T> variable)
        {
            l.AddRange(variable);
            Console.WriteLine("Inserted");
        }
    }
}
