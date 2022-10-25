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

        private void LoadList(IEnumerable<Driver>? list = null)
        {
            list ??= driverRepository.GetAll();

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
                    cbnp.Text.Any() ? cbnp.Text : null
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
