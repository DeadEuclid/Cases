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
    public partial class TripForm : Form
    {
        private infoView info;
        public TripForm(searchView searchResult)
        {
            InitializeComponent();
            info = new infoView(searchResult);
            trainNum.Text = info.TrainNum.ToString();
            departureTime.Text = info.DepatureTimeToString;
            deperturePoint.Text = info.DepaturePoint;
            arrivalPoint.Text = info.ArrivalPoint;
            FCP.Text = info.FirstClassPrice.ToString();
            SCP.Text = info.SecondClassPrice.ToString();
            FCEP.Text = info.FirstClassExemPrice.ToString();
            SCEP.Text = info.SecondClassExemPrice.ToString();
            FCSeets.Text = info.plasesFirst;
            SCSeets.Text = info.plasesSecond;
            if (searchView.freeSeats(searchResult.GetTrip))
                getTicketButton.Enabled = true;
        }

        private void getTicketButton_Click(object sender, EventArgs e)
        {
            var tiketForm = new TicketForm(info);
            var dResult = tiketForm.ShowDialog();
            if (dResult==DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
