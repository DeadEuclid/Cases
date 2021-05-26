using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewer;

namespace DbMock
{
    class Controller
    {
        public Controller(Route route)
        {
            Route = route;
        }
        public Controller(Trip trip)
        {
            Trip = trip;
        }

        private StationContext Rep;
        private Route Route;
        private Trip Trip;
        /// <summary>
        /// Билеты на маршрут
        /// </summary>
        private List<Ticket> thisRouteTickets => (List<Ticket>)Rep.Tickets.Where(t => t.Trip.TimeTable.Route == this.Route);
        /// <summary>
        /// Рейсы на маршруте
        /// </summary>
        private List<Ticket> thisTripTickets => (List<Ticket>)Rep.Tickets.Where(t=>t.Trip==Trip);
        private List<Trip> thisRouteTrips => (List<Trip>)Rep.Trips.Where(t => t.TimeTable.Route == this.Route);
        /// <summary>
        /// Поезда на данном маршруте на данном расписании
        /// </summary>
        // private List<Train> trains => (List<Train>)thisRouteTickets.Where(t => thisRouteTimeTable.Contains(t.Trip.TimeTable)).Select(t => t.Trip.Train);
        /// <summary>
        /// Количестово мест на маршруте
        /// </summary>
        private int ByedPlases(Trip trip)
        {
            return Rep.Tickets.Where(tiket=>tiket.Trip==trip).Count();
        }
        public bool WithFreePlases(TripInfo info)
        {
            Trip trip = info.GetTrip;
            return ByedPlases(trip) == trip.Train.SeatsCount;
        }
        private int GetSeatsCountOnRoute => thisRouteTrips.Select(r => r.Train.SeatsCount).Sum();
        public int GetBuyedSeatsCountRoute => thisRouteTickets.Count();
        public double GetRevenue => thisRouteTickets.Select(t => t.Price).Sum();
        public string GetRouteTitle => Route.Name;
        public DateTime GetDepartureDate => Trip.DepartureDate;
        public DateTime GetDepartureTime => Trip.TimeTable.DepartureTime;
        public string GetTimetable => Trip.TimeTable.WeekTable;
        //public int GetGeneralPrecentageOcupatedPlases()
        //{
        //    var generalCountByed = GetByedSeatsCount(WagonClass.First, false) + GetByedSeatsCount(WagonClass.First, true) + GetByedSeatsCount(WagonClass.Second, false) + GetByedSeatsCount(WagonClass.Second, true);

     //   }
        private int GetPercentageOccupidPlaces(int buyedSeatsCount,int fullSeatsCount)
        { 
                return GetBuyedSeatsCountRoute / ((fullSeatsCount + (fullSeatsCount - buyedSeatsCount)) / 100);
        }
        private int GetByedSeatsCount(List<Route> routes,WagonClass wagonClass,bool isExem)////?????????Было плохо проверять внимательно
        {
            if (isExem)
            {
                return thisRouteTickets.Where(t => t.Wagon.WagonClass == wagonClass && t.ExemType != ExemType.None).Select(t=>t.Wagon.SeatsCount).Sum();
            }
            return thisRouteTickets.Where(t => t.Wagon.WagonClass == wagonClass && t.ExemType == ExemType.None).Select(t => t.Wagon.SeatsCount).Sum();

        }



    }
}
