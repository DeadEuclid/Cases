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
        public TripForm(Trip trip)
        {
            InitializeComponent();
            TrainNumber.Text ="15";
            this.DepartureTime.Text = "31 мая 2021 21:30";
            this.DeparturePoint.Text = "Рубцовск";
            this.ArrivalPoint.Text = "Змеиногорск";
            int basePrice=900;
            this.SecondClassPrice.Text =Convert.ToString( basePrice);
            this.FirstClassPrice.Text =Convert.ToString( basePrice*1.3);
            this.FirstClassExemPrice.Text = Convert.ToString(basePrice * 1.3 * 0.5);
            this.SecondClassExemPrice.Text = Convert.ToString(basePrice  * 0.5);
        }

        private void ArrivalPoint_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
