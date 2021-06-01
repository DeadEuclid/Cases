using AutoGrid;
using CasesViews;
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
        StationContext Context = new StationContext();
        public SearchControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = ViewContext.Searches;

            departurePoints.DataSource = Context.Stations.ToList();
            departurePoints.DisplayMember = "Name";

            arrivalPoints.DataSource = Context.Stations.ToList();
            arrivalPoints.DisplayMember = "Name";

        }
        private BindingList<searchView> views;
        private void UpdateViews()
        {
            ViewContext.Searches = new BindingList<searchView>(Context.Trips.ToList().Select((trip, i) => new searchView(i, trip)).ToList());
        }
        private void UpdateViews(Station dep,Station arriv,bool withFreeSeats)
        {
            ViewContext.Searches = 
                new BindingList<searchView>
                (Context.Trips.Where(trip=>
                (trip.TimeTable.Route.Stations.First().Id==dep.Id&& trip.TimeTable.Route.Stations.Last().Id == arriv.Id) &&
                (!withFreeSeats|| searchView.freeSeats(trip)))
                .Select((trip,i) => new searchView(i+1, trip)).ToList());
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }
        private void SearchControl_Load(object sender, EventArgs e)
        {
            UpdateViews();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UpdateViews();
        }

        private void moreInfo_Click(object sender, EventArgs e)
        {
            var tripForm = new TripForm((searchView)dataGridView1.SelectedRows[0].DataBoundItem);
            tripForm.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            UpdateViews((Station)departurePoints.SelectedItem, (Station)arrivalPoints.SelectedItem,checkBox1.Checked);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                moreInfo.Enabled = true;
            else
                moreInfo.Enabled = false;
        }
    }

}
