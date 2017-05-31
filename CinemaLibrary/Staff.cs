using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CinemaLibrary
{
    [Table()]
    public class Staff
    {
        [Column (IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public string LoginName { get; set; }
        [Column]
        public string Pass { get; set; }
        [Column]
        public int Role { get; set; }
    }
}
