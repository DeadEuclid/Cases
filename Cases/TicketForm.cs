
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
    public partial class TicketForm : Form
    {
        StationContext Context = new StationContext();
        infoView infoView;
        int resultPrice;
         public TicketForm(infoView info)
        {
            InitializeComponent();
            trainNum.Text = info.TrainNum.ToString();
            arrivalPoint.Text = info.ArrivalPoint;
            deperturePoint.Text = info.DepaturePoint;
            departureTime.Text = info.DepatureTimeToString;
            wagonNum.DataSource = info.GetTrip.Train.Wagons.ToList();
            wagonNum.DisplayMember = "Name";
            exemType.DataSource = new string[] { "Студенческая", "Герой труда", "Ветеран ВОВ"};
            exemType.Text = "Без льгот";
            infoView = info;
            resultPrice = info.SecondClassPrice;
            
        }
       // StationContext stationContext=new StationContext();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
            if (Exem.Checked)
                exemType.Enabled = true;
            else
                exemType.Text = "Без льгот";
                exemType.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void getTicketButton_Click(object sender, EventArgs e)
        {
            Person person;
            Ticket ticket;
            var trip = infoView.GetTrip;
            if (checkValue(Surname) && checkValue(FirstName) && checkValue(pasportSeria) && checkValue(pasportNum))
            {
                var wagon = Context.Wagons.Find(((Wagon)wagonNum.SelectedItem).Id);
                var depStation = Context.Stations.Find(trip.TimeTable.Route.Stations.First().Id);
                var arrivStation = Context.Stations.Find(trip.TimeTable.Route.Stations.Last().Id);
                var thisTrip = Context.Trips.Find(trip.Id);

                DialogResult = DialogResult.OK;
                ticket = new Ticket(trip.TimeTable.DepartureTime,depStation ,arrivStation ,wagon , (int)seatNum.SelectedValue,int.Parse( pasportSeria.Text),int.Parse( pasportNum.Text), Surname.Text, FirstName.Text, Middlename.Text,thisTrip );
                Context.Tickets.Add(ticket);
                Context.Persons.Add(new Person(FirstName.Text,Surname.Text,  Middlename.Text));
                Context.SaveChanges();
                Close();
            }    

            else
                MessageBox.Show("Введите все данные пассажира");
        }
        
        private bool checkValue(TextBox textBox)
        {
            if (textBox.Text == null || textBox.Text == "")
                return false;
            return true;
        }
        private void wagonNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wagonNum.SelectedItem!=null)
            {
                seatNum.Enabled = true;
            var seats = new bool[((Wagon)wagonNum.SelectedValue).SeatsCount];
            var selledNums=Context.Tickets.Where(ticket=>ticket.Wagon.Id==((Wagon)wagonNum.SelectedValue).Id).Select(tiket=>tiket.PalesNum);
            var freeNums = new List<int>();
            for (int i = 1; i <= ((Wagon)wagonNum.SelectedValue).SeatsCount; i++)
            {
                if (!selledNums.Contains(i))
                    freeNums.Add(i);
            }
            seatNum.DataSource = freeNums;
                updatePrice();
                seatNum.SelectedIndex = 0;
            }
            else
            {
                seatNum.Enabled = false;
            }

        }
        private void updatePrice()
        {
            if (((Wagon)wagonNum.SelectedItem).WagonClass == WagonClass.First)
                resultPrice = Exem.Checked ? infoView.FirstClassExemPrice : infoView.FirstClassPrice;
            else
                resultPrice = Exem.Checked ? infoView.SecondClassExemPrice : infoView.SecondClassPrice;
            Price.Text = resultPrice.ToString();
        }
        private string StringNullable(string value)
        {
            return value == null ? "" : value;
        }
    }
}
