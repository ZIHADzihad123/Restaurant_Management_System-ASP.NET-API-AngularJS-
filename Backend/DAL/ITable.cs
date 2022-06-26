using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface ITable<T>
    {
        List<T> GetAllTable();
        List<T> GetReservedTable();
        List<T> GetNonReservedTable();
        void TableReserve(T dl);
    }
}
