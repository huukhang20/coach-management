using BusinessObject;
using CoachManagement.TicketUI;
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

namespace CoachManagement
{
    public partial class frmTicket : Form
    {
        private ITicketRepository ticketRepository = new TicketRepository();

        public frmTicket(int? tripId)
        {
            InitializeComponent();
            if (tripId != null)
                txtSearchTrip.Text = tripId.ToString();
        }

        private void LoadList()
        {
            try
            {
                IEnumerable<Ticket> rawList = ticketRepository.GetAll();
                List<Ticket> list = FilterTickets(rawList).ToList();

                txtId.DataBindings.Clear();
                txtSeatNum.DataBindings.Clear();
                txtBookTime.DataBindings.Clear();
                txtTripId.DataBindings.Clear();
                txtPassengerId.DataBindings.Clear();

                txtId.DataBindings.Add("Text", list, "Id");
                txtSeatNum.DataBindings.Add("Text", list, "SeatNumber");
                txtBookTime.DataBindings.Add("Value", list, "BookTime");
                txtTripId.DataBindings.Add("Text", list, "TripId");
                txtPassengerId.DataBindings.Add("Text", list, "PassengerId");

                dgvTickets.DataSource = list;
                dgvTickets.Columns[5].Visible = false;
                dgvTickets.Columns[6].Visible = false;

                if (list.Any())
                {
                    btnDelete.Enabled = true;
                    btnReceipe.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnReceipe.Enabled = false;
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private IEnumerable<Ticket> FilterTickets(IEnumerable<Ticket> list)
        {
            if (!txtSearchPassenger.Text.Any() && !txtSearchTrip.Text.Any())
                return Enumerable.Empty<Ticket>();

            return list.Where(x => (!txtSearchPassenger.Text.Any() || x.PassengerId.Equals(txtSearchPassenger.Text))
                && (!txtSearchTrip.Text.Any() || x.TripId == long.Parse(txtSearchTrip.Text)))
                .OrderByDescending(t => t.TripId)
                .ThenBy(t => t.PassengerId);
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtSeatNum.Text = "";
            txtBookTime.Text = "";
            txtTripId.Text = "";
            txtPassengerId.Text = "";
        }

        private Ticket? GetSelected()
        {
            try
            {
                return new Ticket(
                    long.Parse(txtId.Text),
                    txtBookTime.Value,
                    int.Parse(txtSeatNum.Text),
                    txtPassengerId.Text,
                    long.Parse(txtTripId.Text)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTicketAdd frmDriverDetails = new frmTicketAdd();
            if (frmDriverDetails.ShowDialog() == DialogResult.OK)
                LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket? driver = GetSelected();
                if (driver != null)
                {
                    DialogResult res = MessageBox.Show(
                        "Delete ticket with id " + driver.Id,
                        "Delete",
                        MessageBoxButtons.OKCancel
                    );
                    if (res == DialogResult.OK)
                    {
                        ticketRepository.Remove(driver.Id);
                        LoadList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnReceipe_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket? ticket = GetSelected();
                frmTickertDetail frmTicketDetail = new frmTickertDetail(ticket);
                if (frmTicketDetail.ShowDialog() == DialogResult.OK)
                    LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void dgvTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    frmDriverDetails frmDriverDetails = new frmDriverDetails(GetSelected());
        //    if (frmDriverDetails.ShowDialog() == DialogResult.OK)
        //    {
        //        LoadList();
        //    }
        //}
    }
}
