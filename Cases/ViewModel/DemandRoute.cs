using AutoGrid;
using Viewer;


namespace Cases.ViewModel
{
    class DemandRoute
    {
        public DemandRoute(Route route,int number)
        {
            Number = number;
            RouteTitle = route.Name;
            var countSeats = 
            //PercentageOccupidPlaces = preReport.BuyedSeats / ((preReport.BuyedSeats + preReport.VoidSeats) / 100);

            GetRoute = route;

        }
        private StationContext Rep = new StationContext();
        [Title("№")]
        public int Number { get; set; }
        [Title("Маршрут")]
        public string RouteTitle { get; set; }
        [Title("Процент занятых мест")]
        public int PercentageOccupidPlaces { get; set; }
        [Title("Процент занятых мест в 1-ом классе")]
        public int PercentageOccupidPlacesInFirstClass { get; set; }
        [Title("Процент занятых мест во 2-ом классе")]
        public int PercentageOccupidPlacesInSecondClass { get; set; }
        [Title("Процент занятых льготных меств 1-ом классе")]
        public int PercentageOccupidExemPlacesInFirstClass { get; set; }
        [Title("Процент льготных мест во 2-ом классе")]
        public int PercentageOccupidExemPlacesInSecondClass { get; set; }
        public Route GetRoute { get; }
 
    }
}
