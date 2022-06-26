using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableRepo: ITable<Table>
    {
        BlogsEntities db;
        public TableRepo(BlogsEntities db)
        {
            this.db = db;
        }
        public  List<Table> GetAllTable()
        {
            return db.Tables.ToList();
        }

        public List<Table> GetReservedTable()
        {
            var data = (from e in db.Tables
                        where e.Status == "Reserved"
                        select e).ToList();
            return data;
        }

        public List<Table> GetNonReservedTable()
        {
            var data = (from e in db.Tables
                        where e.Status == "Not Reserved"
                        select e).ToList();
            return data;
        }

      
        public void TableReserve(Table dl)
        {
            var prod = dl.Id;
            var uprice = (from s in db.Tables
                          where s.Id == prod
                          select s).FirstOrDefault();
            Table d = new Table()
            {
                Id = prod,
                TablePosition = uprice.TablePosition,
                Levels = uprice.Levels,
                Reservation_Date = DateTime.Now.AddDays(2),
                Status="Reserved"
            };
            db.Entry(uprice).CurrentValues.SetValues(d);
            db.Entry(uprice).State = System.Data.EntityState.Modified;

            db.SaveChanges();
        }

       
    }
}
