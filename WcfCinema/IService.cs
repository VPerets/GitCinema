using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.ServiceModel;
using System.Web;
using CinemaLibrary;

namespace WcfCinema
{

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        int Login(string login, string pass);

        [OperationContract]
        Point[] GetSoldPlaces(int idFilm, DateTime dateTime);

        [OperationContract]
        bool ReserveTickets(int idHall, int idFilm, DateTime date, Point lineSeat, string mail);

        [OperationContract]
        SoldTickets getReserveByCode(int codeReserve);

        [OperationContract]
        SoldTickets getReserveByNumber(string number);

        //[OperationContract]


    }
}