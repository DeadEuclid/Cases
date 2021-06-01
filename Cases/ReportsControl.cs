using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoGrid;
using CasesViews;
using Viewer;

namespace Cases
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
            routeDataGrid.DataSource = ViewContext.Demands;
            sellDataGrid.DataSource = ViewContext.Sells;
            UpdateVews();
            //Init();

        }
        public DataGridProcessor SellReportProcessor { get; set; }
        public DataGridProcessor RouteReportProcessor { get; set; }




        private void ReportsControl1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateVews()
        {
            var context = new StationContext();
            ViewContext.Demands = new BindingList<demandView>(context.Routes.ToList().Select((route, i) => new demandView(i + 1, route, startTime.Value, endTime.Value)).ToList());
            ViewContext.Sells = new BindingList<sellView>(context.Routes.ToList().Select((route, i) => new sellView(i + 1, route, startTime.Value, endTime.Value)).ToList());
        }
        private void endTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateVews();
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateVews();
        }
    }
}

