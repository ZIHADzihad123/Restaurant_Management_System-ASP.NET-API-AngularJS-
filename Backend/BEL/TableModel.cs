using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class TableModel
    {
        public int Id { get; set; }
        public string TablePosition { get; set; }
        public int Levels { get; set; }
        public System.DateTime Reservation_Date { get; set; }
        public string Status { get; set; }
    }
}
