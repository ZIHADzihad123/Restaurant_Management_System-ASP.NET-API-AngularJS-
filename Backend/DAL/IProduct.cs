using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProduct<T, ID>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        Product Edit(T e);
        Product aEdit(T e);
        void Delete(ID id);
    }
}
