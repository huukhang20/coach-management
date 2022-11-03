using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachManagement
{
    public partial class frmTicketAdd : Form
    {
        private ITripRepository tripRepository = new TripRepository();
        private IPassengerRepository passengerRepository = new PassengerRepository();
        private ITicketRepository ticketRepository = new TicketRepository();

        public frmTicketAdd()
        {
            InitializeComponent();
        }

        private void btnSeachTrip_Click(object sender, EventArgs e)
        {
            try
            {
                txtFrom.Text = "";
                txtTo.Text = "";
                txtDepart.Text = "";
                txtPrice.Text = "";
                checkedListBoxSeats.Items.Clear();

                Trip? trip = tripRepository.GetById(long.Parse(txtTripId.Text));
                if (trip != null)
                {
                    txtFrom.Text = trip.From;
                    txtTo.Text = trip.To;
                    txtDepart.Value = trip.DepartTime;
                    txtPrice.Text = trip.Price.ToString();

                    // display seats
                    if (trip != null && trip.NumberPlateNavigation != null)
                    {
                        // find all bought tickets of this trip
                        IEnumerable<int> boughtTickets = ticketRepository.GetAll()
                            .Where(t => t.TripId == trip.Id)
                            .Select(t => t.SeatNumber);

                        // available tickets are the one not amoung bought tickets
                        for (int i = 1; i <= trip.NumberPlateNavigation.Seats; i++)
                            if (!boughtTickets.Contains(i))
                                checkedListBoxSeats.Items.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchPassenger_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            lbAddPassenger.Visible = false;

            Passenger? passenger = passengerRepository.GetById(txtPassengerId.Text);
            if (passenger != null)
            {
                txtName.Text = passenger.Name;
                txtPhone.Text = passenger.Phone;
            }
            else if (txtPassengerId.Text.Any())
                lbAddPassenger.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Passenger passenger = new Passenger(txtPassengerId.Text, txtName.Text, txtPhone.Text);
                if (lbAddPassenger.Visible)
                {
                    passengerRepository.Add(passenger);
                }
                else passengerRepository.Update(passenger);

                if (tripRepository.GetById(long.Parse(txtTripId.Text)) != null)
                {
                    foreach (var seat in checkedListBoxSeats.CheckedItems)
                    {
                        ticketRepository.Add(new Ticket(
                            0,
                            DateTime.Now,
                            int.Parse(seat.ToString()),
                            txtPassengerId.Text,
                            long.Parse(txtTripId.Text)
                        ));
                    }
                }
                else throw new Exception("Trip not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }
    }
}
