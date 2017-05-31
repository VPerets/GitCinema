using CinemaLibrary;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Configuration;
using System.Text;

namespace WcfCinema
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.Single,
        IncludeExceptionDetailInFaults = true)]

    public class Service : IService
    {
        public DataContext datacontext;
        public Service()
        {
            DbConnection cn;
            cn = new System.Data.SqlClient.SqlConnection();
            //  cn.ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=cinema;Integrated Security=True";
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["CinemaConnectionString"].ConnectionString;
            datacontext = new DataContext(cn);
        }

        public int Login(string login, string pass)
        {
         
            var staff = (from s in datacontext.GetTable<Staff>()
                         where s.LoginName == login && s.Pass == pass
                         select s);

          
            if (staff.Count() == 0) return -1;

            return staff.First().Role;
        }

        public int some()
        {
            DbConnection cn;
            cn = new System.Data.SqlClient.SqlConnection();
            //  cn.ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=cinema;Integrated Security=True";
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["CinemaConnectionString"].ConnectionString;
            datacontext = new DataContext(cn);
            return datacontext.GetTable<Movies>().First().ID;
        }


        public Point[] GetSoldPlaces(int idFilm, DateTime date)
        {
            List<MovieSessions> Session = getSession(idFilm, date);
            if (Session.Count() == 0)
                return new Point[] { };


            var soldTickets = from t in datacontext.GetTable<SoldTickets>()
                              from o in datacontext.GetTable<Orders>()
                              where o.SessionId == Session.First().ID
                              && t.OrderId == o.ID
                              select new Point { X = t.Line, Y = t.Seat };

            if (soldTickets.Count() == 0) return new Point[] { };

            return soldTickets.ToArray();
        }

        public List<MovieSessions> getSession(int idFilm, DateTime date)
        {
            var session = (from s in datacontext.GetTable<MovieSessions>()
                           where s.SessionDateTime.Value == date && s.Movie == idFilm
                           select s);

            return session.ToList();
        }

        public bool ReserveTickets(int idHall, int idFilm, DateTime date, Point lineSeat, string mail)
        {
            var session = getSession(idFilm, date);

            var soldTickets = from t in datacontext.GetTable<SoldTickets>()
                              from o in datacontext.GetTable<Orders>()
                              where o.SessionId == session.First().ID
                              && t.OrderId == o.ID && t.Line == lineSeat.X && t.Seat == lineSeat.Y
                              select t;

            if (soldTickets.Count() == 0)
            {
                var order = new Orders
                {
                    Customer =1,
                    SessionId = session.First().ID
                };
                datacontext.GetTable<Orders>().InsertOnSubmit(order);
                datacontext.SubmitChanges();
                var order_forID = from o in datacontext.GetTable<Orders>().AsEnumerable()
                              where o == order
                              select o;
                int idOrder = order_forID.First().ID;

                var reserveTicket = new SoldTickets
                {
                    Line = lineSeat.X,
                    Seat = lineSeat.Y,
                    OrderId = idOrder,
                    Price = 20
                };

                datacontext.GetTable<SoldTickets>().InsertOnSubmit(reserveTicket);
                datacontext.SubmitChanges();
                return true;
            }

            return false;
        }

        public SoldTickets getReserveByCode(int codeReserve)
        {
            var ticket = datacontext.GetTable<SoldTickets>()
                .Where(t => t.OrderId == codeReserve)
                .Select(t => t);

            return ticket.First();
        }

        public SoldTickets getReserveByNumber(string number)
        {
            var customerID = datacontext.GetTable<Customers>()
                .Where(c => c.PhoneNumber == number).Select(c => c.ID);

            var order = datacontext.GetTable<Orders>()
                .Where(o => o.Customer == customerID.First())
                .Select(o => o.ID);
            
            var ticket = datacontext.GetTable<SoldTickets>()
                .Where(t => t.OrderId == order.First())
                .Select(t => t);

            return ticket.First();
        }

    }
}
