using BusinessObject;
using DataAccess.Repository;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CoachManagement.CoachUI;

namespace CoachManagement
{

    public partial class frmCoach : Form
    {
        private CoachRepository coachRepo = new CoachRepository();
        public frmCoach()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            try
            {
                IEnumerable<Coach> rawList = coachRepo.GetAll();
                List<Coach> list = FilterCoach(rawList).ToList();

                txtNumberPlate.DataBindings.Clear();
                txtSeat.DataBindings.Clear();
                txtBrand.DataBindings.Clear();
                txtLocation.DataBindings.Clear();

                txtNumberPlate.DataBindings.Add("Text", list, "NumberPlate");
                txtSeat.DataBindings.Add("Text", list, "Seats");
                txtBrand.DataBindings.Add("Text", list, "Brand");
                txtLocation.DataBindings.Add("Text", list, "Location");

                dgvCoachs.DataSource = list;
                dgvCoachs.Columns[5].Visible = false;
                dgvCoachs.Columns[6].Visible = false;

                if (Login.IsAdmin)
                {
                    if (list.Any())
                        btnDelete.Enabled = true;
                    else
                    {
                        btnDelete.Enabled = false;
                        ClearText();
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private IEnumerable<Coach> FilterCoach(IEnumerable<Coach> list)
        {
            return list.Where(x => x.NumberPlate.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)
                && (!cbFilter.Text.Any() || cbFilter.Text.Equals(x.Brand)))
                .OrderByDescending(d => d.Brand) ;
        }
        private void ClearText()
        {
            txtNumberPlate.Text = "";
            txtSeat.Text = "";
            txtBrand.Text = "";
            txtLocation.Text = "";
        }
        private Coach? GetSelected()
        {
            try
            {
                return new Coach(
                    txtNumberPlate.Text,
                    int.Parse(txtSeat.Text),
                    true,
                    txtBrand.Text,
                    txtLocation.Text
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void frmCoach_Load(object sender, EventArgs e)
        {
            if (!Login.IsAdmin)
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                dgvCoachs.CellDoubleClick += new DataGridViewCellEventHandler(dgvCoachs_CellDoubleClick);
            }

            LoadList();

            ICoachRepository coachRepository = new CoachRepository();
            var brand = coachRepository.GetAll()
                .Select(c => c.Brand)
                .ToArray();
            cbFilter.Items.AddRange(brand);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Coach? coach = GetSelected();
                if (coach != null)
                {
                    DialogResult res = MessageBox.Show(
                        "Delete driver with number plate " + coach.NumberPlate,
                        "Delete",
                        MessageBoxButtons.OKCancel
                    );
                    if (res == DialogResult.OK)
                    {
                        coachRepo.Remove(coach.NumberPlate);
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
            frmCoachAdd frmCoachAdd = new frmCoachAdd(null);
            frmCoachAdd.Text = "Add New Coach";
            if (frmCoachAdd.ShowDialog() == DialogResult.OK)
                LoadList();
        }

        private void dgvCoachs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCoachAdd frmCoachAdd = new frmCoachAdd(GetSelected());
            frmCoachAdd.Text = "Update Coach";
            if (frmCoachAdd.ShowDialog() == DialogResult.OK)
                LoadList();
        }
    }
}
