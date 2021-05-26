
using AutoGrid;
using Cases.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer;

namespace Cases
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();  


            processor = new DataGridProcessor(dataGridView1, tripModels, typeof(TripInfo));
            tripModels = new BindingList<TripSearch>();
            List<TripSearch> trips_models = new List<TripSearch>
                (
                new TripSearch()
                
                );


        }
        private BindingList<TripSearch> tripModels;
        private BindingList<TripSearch> ListToBindList(List<TripSearch> trips_models)
        {
            return new BindingList<TripSearch>(trips_models);
        }
        private void UpdateSerch(Station Departure,Station Arrival,DateTime date,bool isWithFreeSeets)
        {
            var withoutSeats = tripModels.Where(trip => trip.GetDeparturePoint == Departure && trip.GetArrivalPoint == Arrival).ToList();
            if (isWithFreeSeets)
                tripModels = ListToBindList(withoutSeats.Where(tripModel => WithFreePlases(tripModel)).ToList());
            else
                tripModels = ListToBindList(withoutSeats);
        }
        private void UpdateSearch()
        { 
            //tripModels = ListToBindList(Context.Trips.Select(trip=>new TripSearch(trip,trip.)));
            //foreach (var item in  )
            //{

            //}
        
        }
        private DataGridProcessor processor;
        private StationContext Context = new StationContext();

    }

}
