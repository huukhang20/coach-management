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

namespace CoachManagement
{
    public partial class frmDriver : Form
    {
        private IDriverRepository driverRepository = new DriverRepository();

        public frmDriver()
        {
            InitializeComponent();
        }

        private void LoadList()
        {
            IEnumerable<Driver> rawList = driverRepository.GetAll();
            List<Driver> list = FilterDrivers(rawList).ToList();

            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtBirthday.DataBindings.Clear();
            txtPosition.DataBindings.Clear();
            cbnp.DataBindings.Clear();

            txtId.DataBindings.Add("Text", list, "Id");
            txtName.DataBindings.Add("Text", list, "Name");
            txtBirthday.DataBindings.Add("Value", list, "Birthday");
            txtPosition.DataBindings.Add("Text", list, "Position");
            cbnp.DataBindings.Add("Text", list, "NumberPlate");

            dgvDrivers.DataSource = list;
            dgvDrivers.Columns[5].Visible = false;

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

        private IEnumerable<Driver> FilterDrivers(IEnumerable<Driver> list)
        {
            return list.Where(x => x.Name.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)
                && (!cbFilter.Text.Any() || cbFilter.Text.Equals(x.NumberPlate)))
                .OrderByDescending(d => d.Id);
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            txtPosition.Text = "";
            cbnp.Text = "";
        }

        private Driver? GetSelected()
        {
            try
            {
                return new Driver(
                    txtId.Text,
                    txtName.Text,
                    txtPosition.Text,
                    txtBirthday.Value,
                    cbnp.Text
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
            if (!Login.IsAdmin)
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }
            else dgvDrivers.CellDoubleClick += new DataGridViewCellEventHandler(dgvDrivers_CellDoubleClick);

            LoadList();

            ICoachRepository coachRepository = new CoachRepository();
            var numberPlates = coachRepository.GetAll()
                .Select(c => c.NumberPlate)
                .ToArray();
            cbnp.Items.AddRange(numberPlates);
            cbFilter.Items.AddRange(numberPlates);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDriverDetails frmDriverDetails = new frmDriverDetails(null);
            if (frmDriverDetails.ShowDialog() == DialogResult.OK)
                LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Driver? driver = GetSelected();
                if (driver != null)
                {
                    DialogResult res = MessageBox.Show(
                        "Delete driver with id" + driver.Id,
                        "Delete",
                        MessageBoxButtons.OKCancel
                    );
                    if (res == DialogResult.OK)
                    {
                        driverRepository.Remove(driver.Id);
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dgvDrivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDriverDetails frmDriverDetails = new frmDriverDetails(GetSelected());
            if (frmDriverDetails.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }
    }
}
