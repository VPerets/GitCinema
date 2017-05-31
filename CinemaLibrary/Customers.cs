using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CinemaLibrary
{
    [Table()]
    public class Customers
    {
        [Column (IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column]
        public string FullName { get; set; }
        [Column]
        public string PhoneNumber { get; set; }
        [Column]
        public string EMail { get; set; }
    }
}
