using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using CinemaLibrary;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestForDB
{
    [TestClass]
    public class UnitTest1
    {
        DataContext datacontext;

        public UnitTest1()
        {
            DbConnection cn;
            cn = new System.Data.SqlClient.SqlConnection();

            cn.ConnectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=cinema;Integrated Security=True";
            datacontext = new DataContext(cn);

        }
        [TestMethod]
        public void TestHalls()
        {
            string expected = "Blue";

            string actual = datacontext.GetTable<Halls>().First().Title;

            Assert.AreEqual(expected, actual);

            expected = "Green";

            var hall = new Halls { Title = "Green", Lines = 10, Seats = 10 };

            datacontext.GetTable<Halls>().InsertOnSubmit(hall);

            datacontext.SubmitChanges();

            int max = (from h in datacontext.GetTable<Halls>() select h.ID).Max();
            actual = (from h in datacontext.GetTable<Halls>() where h.ID == max select h.Title).First();

            Assert.AreEqual(expected, actual);

            Halls hall2 = (from h in datacontext.GetTable<Halls>() where h.ID == max select h).First();

            datacontext.GetTable<Halls>().DeleteOnSubmit(hall2);
            datacontext.SubmitChanges();

            int exp = 2;
            int actuall = (from h in datacontext.GetTable<Halls>() select h.ID).Max();
            Assert.AreEqual(exp, actuall);

        }

        [TestMethod]
        public void TestCustomers()
        {

            string expected = "Perets Vitaliia";

            string actual = datacontext.GetTable<Customers>().First().FullName;

            Assert.AreEqual(expected, actual);

            var cust = new Customers { FullName = "Pupkin", EMail = "mail.ru", PhoneNumber = "1111" };
            datacontext.GetTable<Customers>().InsertOnSubmit(cust);
            datacontext.SubmitChanges();
            expected = "Pupkin";
            actual = (from c in datacontext.GetTable<Customers>()
                      where c.PhoneNumber == "1111"
                      select c.FullName).First();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMovies()
        {
            // checking for take info from DB
            string expected = "Terminator";

            var actual = datacontext.GetTable<Movies>().First().Title;

            Assert.AreEqual(expected, actual);

            //remember our id and add new movie into the base
            int currId = (from m in datacontext.GetTable<Movies>() where m.Title == "Terminator" select m.ID).First();

            string movieMax = (from m in datacontext.GetTable<Movies>()
                               where m.ID == currId
                               select m).First().Title;

            Movies mov = new Movies { Title = "The Lord of Rings" };

            datacontext.GetTable<Movies>().InsertOnSubmit(mov);
            datacontext.SubmitChanges();

            bool bool_act = (from mm in datacontext.GetTable<Movies>() where mm.Title == "The Lord of Rings" select mm).Any();

            bool exp = true;
            Assert.AreEqual(exp, bool_act);

            //delete our tempMovie from the base 

            while (true)
            {
                int maxID = (from m in datacontext.GetTable<Movies>() select m.ID).Max();
                if (maxID == currId) break;

                var movie = from mm in datacontext.GetTable<Movies>() where mm.ID == maxID select mm;
                datacontext.GetTable<Movies>().DeleteOnSubmit(movie.First());
                datacontext.SubmitChanges();
            }

            int idActual = (from m in datacontext.GetTable<Movies>() select m.ID).Max();
            Assert.AreEqual(currId, idActual);
        }

        [TestMethod]
        public void TestStaff()
        {


        }
    }
}
