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
                        status=3;
                        break;
                }
                Trip trip = new Trip(
                    txtFrom.Text,
                    txtTo.Text,
                    txtDepart.Value,
                    status,
                    decimal.Parse(txtPrice.Text),
                    txtNumberPlate.Text
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
            if (trip != null)
            {
                String status = "";
                switch (trip.Status)
                {
                    case 0:
                        status = "NotDepart";
                        break;
                    case 1:
                        status = "Departed";
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
            }
        }
    }
}
