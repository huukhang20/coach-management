using BusinessObject;
using DataAccess;
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
    public partial class frmTrip : Form
    {
        private ITripRepository tripRepository = new TripRepository();

        public frmTrip()
        {
            InitializeComponent();
        }

        private void LoadList()
        {
            try
            {

                IEnumerable<Trip> rawlist = tripRepository.GetAll();
                //List<Trip> list = FilterTrips(rawlist).ToList();
                var list = FilterTrips(rawlist)
                    .Select(t => new
                    {
                        t.Id,
                        t.From,
                        t.To,
                        t.DepartTime,
                        Status = (TripStatus)t.Status,
                        t.Price,
                        t.NumberPlate
                    })
                    .ToList();

                txtId.DataBindings.Clear();
                txtFrom.DataBindings.Clear();
                txtTo.DataBindings.Clear();
                txtDepartTime.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtNumberPlate.DataBindings.Clear();

                txtId.DataBindings.Add("Text", list, "Id");
                txtFrom.DataBindings.Add("Text", list, "From");
                txtTo.DataBindings.Add("Text", list, "To");
                txtDepartTime.DataBindings.Add("Value", list, "DepartTime");
                txtStatus.DataBindings.Add("Text", list, "Status");
                txtPrice.DataBindings.Add("Text", list, "Price");
                txtNumberPlate.DataBindings.Add("Text", list, "NumberPlate");

                dgvTrip.DataSource = list;
                //dgvTrip.Columns[7].Visible = false;
                //dgvTrip.Columns[8].Visible = false;
                if (Login.IsAdmin)
                {
                    if (list.Any())
                    {
                        btnDelete.Enabled = true;
                        btnNew.Enabled = true;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                        btnDelete.Enabled = false;
                        ClearText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private IEnumerable<Trip> FilterTrips(IEnumerable<Trip> list)
        {
            return list.Where(x => x.From.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)
                || x.To.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            txtDepartTime.Text = "";
            txtPrice.Text = "";
            txtNumberPlate.Text = "";
            txtStatus.Text = "";
        }

        private Trip? GetSelected()
        {
            try
            {
                return new Trip(
                    long.Parse(txtId.Text),
                    txtFrom.Text,
                    txtTo.Text,
                    txtDepartTime.Value,
                    (int)Enum.Parse(typeof(TripStatus), txtStatus.Text),
                    decimal.Parse(txtPrice.Text),
                    txtNumberPlate.Text
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void frmTrip_Load(object sender, EventArgs e)
        {
            if (!Login.IsAdmin)
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }
            else dgvTrip.CellDoubleClick += new DataGridViewCellEventHandler(dgvTrip_CellDoubleClick);

            LoadList();
        }

        private void dgvTrip_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmTripAdd frmTripAdd = new frmTripAdd(GetSelected());
            frmTripAdd.Text = "Add New Trip";
            if (frmTripAdd.ShowDialog() == DialogResult.OK)
                LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Trip? trip = GetSelected();
                if (trip != null)
                {
                    DialogResult res = MessageBox.Show(
                        "Delete trip with id " + trip.Id,
                        "Delete",
                        MessageBoxButtons.OKCancel
                    );
                    if (res == DialogResult.OK)
                    {
                        tripRepository.Remove(trip.Id);
                        LoadList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTripAdd frmTripAdd = new frmTripAdd(null);
            frmTripAdd.Text = "Add New Trip";
            if (frmTripAdd.ShowDialog() == DialogResult.OK)
                LoadList();
        }
    }
}
