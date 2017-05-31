using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CinemaLibrary
{
    [Table()]
   public class Halls
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column] public string Title { get; set; }
        [Column]public int Lines { get; set; }
        [Column]public int Seats { get; set; }
    }
}
