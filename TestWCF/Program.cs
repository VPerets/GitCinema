using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using TestWCF.ServiceReference;
using System.Threading.Tasks;

namespace TestWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient service = new ServiceClient();
            Console.WriteLine(service.State.ToString());
            //Console.WriteLine(service.some().ToString());
            try
            {
                int i = service.Login("peretsv", "12345");
                Console.WriteLine(i.ToString());
                 List<Point> points = 
                    service.GetSoldPlaces(1, new DateTime(2017, 05, 31, 18, 00, 00)).ToList();
                Console.WriteLine(points[0].x.ToString() + " " + points[0].y.ToString());
                SoldTickets soldTicket = service.getReserveByCode(1);
                Console.WriteLine(soldTicket.Seat.ToString());

                service.ReserveTickets(1, 1, new DateTime(2017, 05, 31, 18, 00, 00), new Point{ x = 2, y =3 }, "peretsvs");

                foreach (var t in service.GetSoldPlaces(1, new DateTime(2017, 05, 31, 18, 00, 00)))
                {
                    Console.WriteLine($"{t.x} {t.y}");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.WriteLine("Some text for commiting");
            Console.WriteLine("Some more text for commiting from local repo and pull with github");

            Console.WriteLine(service.ReserveTickets(1,1, new DateTime(2017, 05, 31, 18, 00, 00), 
                new Point {x = 8, y = 9 }, "perets-vs@ukr.net").ToString());

        }
    }
}
