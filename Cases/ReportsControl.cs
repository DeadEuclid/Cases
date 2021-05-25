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
using Cases.ViewModel;

namespace Cases
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
            Init();

        }
        public DataGridProcessor SellReportProcessor { get; set; }
        public DataGridProcessor RouteReportProcessor { get; set; }
        private void Init()
        {
            SellReportProcessor = new DataGridProcessor(sellDataGrid);
            RouteReportProcessor = new DataGridProcessor(routeDataGrid);
            this.SellReportProcessor.ShowData(new List<TicketReport>(), typeof(TicketReport));
            this.RouteReportProcessor.ShowData(new List<DemandRoute>(), typeof(DemandRoute));

        }

        private void ReportsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
