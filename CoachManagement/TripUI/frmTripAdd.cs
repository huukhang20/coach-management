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

namespace CoachManagement.TripUI
{
    public partial class frmTripAdd : Form
    {
        private Trip? trip;
        private ITripRepository tripRepository = new TripRepository();
        public frmTripAdd(Trip? trip)
        {
            InitializeComponent();
            this.trip = trip;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int status = 0;
                switch (cbStatus.Text)
                {
                    case "NotDepart":
                        status = 0;
                        break;
                    case "Departed":
                        status = 1;
                        break;
                    case "Completed":
                        status = 2;
                        break;
                    case "Canceled":
                        status = 3;
                        break;
                }
                Trip trip = new Trip(
                    this.trip?.Id ?? 0,
                    txtFrom.Text,
                    txtTo.Text,
                    txtDepart.Value,
                    status,
                    decimal.Parse(txtPrice.Text),
                    txtNumberPlate.Text.Any() ? txtNumberPlate.Text : null
                );
                if (this.trip == null)
                    tripRepository.Add(trip);
                else tripRepository.Update(trip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }

        private void frmTripAdd_Load(object sender, EventArgs e)
        {
            var cities = City.Get();
            txtFrom.Items.AddRange(cities);
            txtTo.Items.AddRange(cities);

            ICoachRepository coachRepository = new CoachRepository();
            var numberPlates = coachRepository.GetAll()
                .Select(c => c.NumberPlate)
                .ToArray();
            txtNumberPlate.Items.AddRange(numberPlates);

            cbStatus.SelectedIndex = 0;

            if (trip != null)
            {
                String status = "";
                switch (trip.Status)
                {
                    case 0:
                        status = "NotDepart";
                        btnDepart.Visible = true;
                        break;
                    case 1:
                        status = "Departed";
                        btnDepart.Visible = true;
                        btnDepart.Text = "Arrive";
                        break;
                    case 2:
                        status = "Completed";
                        break;
                    case 3:
                        status = "Canceled";
                        break;
                }

                txtTripId.Text = trip.Id.ToString();
                txtFrom.Text = trip.From;
                txtTo.Text = trip.To;
                txtDepart.Value = trip.DepartTime;
                cbStatus.Text = status;
                txtPrice.Text = trip.Price.ToString();
                txtNumberPlate.Text = trip.NumberPlate;

                if (string.IsNullOrEmpty(txtNumberPlate.Text))
                    btnDepart.Visible = false;
            }
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            try
            {
                Trip trip = tripRepository.GetById(int.Parse(txtTripId.Text))!;
                DialogResult res;
                switch ((TripStatus)trip.Status)
                {
                    case TripStatus.NotDepart:
                        res = MessageBox.Show("Start the trip?", "", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.Cancel) return;
                        trip.Status = (int)TripStatus.Departed;
                        trip.NumberPlateNavigation!.Location = trip.From;
                        break;
                    case TripStatus.Departed:
                        res = MessageBox.Show("End the trip?", "", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.Cancel) return;
                        trip.Status = (int)TripStatus.Completed;
                        trip.NumberPlateNavigation!.Location = trip.To;
                        break;
                }
                tripRepository.Update(trip);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
