using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repository
{
    public interface IGenericRepository<T>
    {
        List<T> Get();
        void Insert(List<T> variable);

        void Delete(T variable);

    }
}
