using System;
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
            RouteTitle = route.Name;
            DeparturePoint = departurePoint.Name;
            ArrivalPoint = arrivalPoint.Name;
            DepartureDate = trip.DepartureDate;
            DepartureTime = trip.TimeTable.DepartureTime;
            TimeTable = trip.TimeTable.WeekTable;
            GetTrip = trip;
            GetDeparturePoint = departurePoint;
            GetArrivalPoint = arrivalPoint;
            //ControllerTrip = new Controller(trip);
            //ControllerRoute = new Controller(trip.TimeTable.Route);
        }
        [Title("№")]
        public int Number { get; set; }
        [Title("Номер поезда")]
        public int TrainNumber { get; set; }
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
}
