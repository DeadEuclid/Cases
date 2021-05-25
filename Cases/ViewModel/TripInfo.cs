using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Viewer;


namespace Cases.ViewModel
{
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
