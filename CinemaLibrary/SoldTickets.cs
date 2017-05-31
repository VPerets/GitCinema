using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CinemaLibrary
{
    [Table()]
    public class SoldTickets
    {
        [Column (IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column]
        public int OrderId { get; set; }
        [Column]
        public int Line { get; set; }
        [Column]
        public int Seat { get; set; }
        [Column]
        public int Price { get; set; }

        public virtual Orders Order { get; set; }
    }
}
