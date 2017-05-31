using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CinemaLibrary
{
    [Table()]
    public class MovieSessions
    {
        [Column (IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]  public int Movie { get; set; }
        [Column] public Nullable<System.DateTime> SessionDateTime { get; set; }
        [Column ]public int Hall { get; set; }
    }
}
