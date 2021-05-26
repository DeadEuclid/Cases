using System.Linq;
using AutoGrid;
using Viewer;


namespace DbMock
{
    public class TicketReport
    {
public TicketReport(Route route,int number)
        {

            Number = number;
            RouteTitle = route.Name;
            var thisRouteTickets = Rep.Tickets.Where(t => t.Trip.TimeTable.Route == route);
            BuyedSeats = thisRouteTickets.Count();
            var thisRouteTimeTable=  Rep.TimeTables.Where(t => t.Route == route);
            var trains = thisRouteTickets.Where(t => thisRouteTimeTable.Contains(t.Trip.TimeTable)).Select(t => t.Trip.Train);
            //VoidSeats= trains.Select(t => t.Wagons.Select(w => w.SeatsCount).Sum()).Sum() - BuyedSeats;
            Revenue = thisRouteTickets.Select(t => t.Price).Sum();
        }

        public TicketReport()
        {
        }

        private StationContext Rep=new StationContext();
        [Title("№")]
        public int Number { get; set; }
        [Title("Маршрут")]
        public string RouteTitle { get; set; }

        [Title("Билетов продано")]
        public int BuyedSeats { get; set; }

        [Title("Выручка")]
        public double Revenue { get; set; }
        public Route GetRoute { get; }
    }
}
