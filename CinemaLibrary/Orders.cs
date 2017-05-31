using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CinemaLibrary
{
    [Table()]
    public
        
        
        class Orders
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column] public int Customer { get; set; }
        [Column]public int SessionId { get; set; }

        public virtual Customers Customer1 { get; set; }
        public virtual MovieSessions MovieSession { get; set; }
    }
}

