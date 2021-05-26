
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
            SearchViewer = new DataViewer();

            processor = new DataGridProcessor(dataGridView1, tripModels, typeof(TripInfo));
            tripModels = new BindingList<TripSearch>();

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
     //       tripModels = ListToBindList(Context.Trips.Select(trip=>new TripSearch(trip,trip.)));
        }
        public DataViewer SearchViewer { get; set; }
        private DataGridProcessor processor;
        private StationContext Context = new StationContext();

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         //   TripForm tripForm = new TripForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tripModels.Where(t => WithFreePlases(t));
            }
            else
            {


            }
        }
        private int ByedPlases(Trip trip)
        {
            return Context.Tickets.Where(tiket => tiket.Trip == trip).Count();
        }
        private bool WithFreePlases(TripSearch info)
        {
            Trip trip = info.GetTrip;
            return ByedPlases(trip) == trip.Train.SeatsCount;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSearch(checkBox1.;
        }
    }

}
