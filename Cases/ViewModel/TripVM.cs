using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGrid;
using Viewer;


namespace Cases.ViewModel
{
    class TripSearch
    {
        public TripSearch( Trip trip,Station departurePoint, Station arrivalPoint,  int number)
        {
            Number = number;
            var route = trip.TimeTable.Route;
            RouteTitle = route.RouteTitle;
            DeparturePoint = departurePoint.Name;
            ArrivalPoint = arrivalPoint.Name;
            DepartureDate = trip.DepartureDate;
            DepartureTime = trip.TimeTable.DepartureTime;
            TimeTable = trip.TimeTable.WeekTable;
            GetTrip = trip;
            GetDeparturePoint = departurePoint;
            GetArrivalPoint = arrivalPoint;

        }
        [Title("№")]
        public int Number { get; set; }
        [Title("Маршрут")]
        public string RouteTitle { get; set; }
        [Title("Место отправления")]
        public string DeparturePoint { get; set; }
        [Title("Место прибытия")]
        public string ArrivalPoint { get; set; }
        [Title("Дата отправления")]
        public DateTime DepartureDate { get; set; }
        [Title("Время отправления")]
        public DateTime DepartureTime { get; set; }
        [Title("Расписание")]
        public string TimeTable { get; set; }
        public Trip GetTrip{ get; }

        public Station GetDeparturePoint;
        public Station GetArrivalPoint;
    }
    class TicketReport
    {
        public TicketReport(Route route,int number)
        {

            Number = number;
            RouteTitle = route.RouteTitle;
            var thisRouteTickets = Rep.Tickets.Where(t => t.Trip.TimeTable.Route == route);
            BuyedSeats = thisRouteTickets.Count();
            var thisRouteTimeTable=  Rep.TimeTables.Where(t => t.Route == route);
            var trains = thisRouteTickets.Where(t => thisRouteTimeTable.Contains(t.Trip.TimeTable)).Select(t => t.Trip.Train);
            VoidSeats= trains.Select(t => t.Wagons.Select(w => w.SeatsCount).Sum()).Sum() - BuyedSeats;
            Revenue = thisRouteTickets.Select(t => t.Price).Sum();
        }
        private StationContext Rep=new StationContext();
        [Title("№")]
        public int Number { get; set; }
        [Title("Маршрут")]
        public string RouteTitle { get; set; }

        [Title("Билетов продано")]
        public int BuyedSeats { get; set; }
        [Title("Билетов не продано")]
        public int VoidSeats { get; set; }
        [Title("Выручка")]
        public double Revenue { get; set; }
        public Route GetRoute { get; }
    }
    class DemandRoute
    {
        public DemandRoute(Route route,int number)
        {
            Number = number;
            RouteTitle = route.RouteTitle;
            var preReport = new TicketReport(route, 0);
            PercentageOccupidPlaces = preReport.BuyedSeats / ((preReport.BuyedSeats + preReport.VoidSeats) / 100);
            GetRoute = route;

        }

        [Title("№")]
        public int Number { get; set; }
        [Title("Маршрут")]
        public string RouteTitle { get; set; }
        [Title("Процент занятых мест")]
        public int PercentageOccupidPlaces { get; set; }
        public Route GetRoute { get; }
 
    }
    class TripInfo
    {
        public TripInfo(TripSearch tripSearch)
        {
            DepartureTime = tripSearch.DepartureDate.AddTicks( tripSearch.DepartureTime.Ticks);
            DeparturePoint = tripSearch.DeparturePoint;
            ArrivalPoint = tripSearch.ArrivalPoint;


            
        }
        private StationContext Rep;
        public DateTime DepartureTime { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }
        public double FirstClassPrice { get; set; }
        public double SecondClassPrice { get; set; }
        public double FirstClassBenefitPrice { get; set; }
        public double SecondClassBenefitPrice { get; set; }
        public string FirstClassSeats { get; set; }
        public string SecondClassSeats { get; set; }
        public Trip GetTrip { get; }

        //private double GetBasePrice(TripSearch tripSearch)
        //{
        //    var startStationIndex = trip.TimeTable.Route.Stations.FindIndex(tripSearch.)
        //}


    }
}
