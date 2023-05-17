using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T, ID>
    {
        List<T> Get();
        T Get(ID id);
        bool Create(T obj);
        bool Update(T obj);
        bool Delete(ID id);
    }
}
