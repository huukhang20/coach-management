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
    public partial class frmDriverDetails : Form
    {
        private Driver? driver;
        private IDriverRepository driverRepository = new DriverRepository();

        public frmDriverDetails(Driver? driver)
        {
            InitializeComponent();
            this.driver = driver;
        }

        private void frmDriverDetails_Load(object sender, EventArgs e)
        {
            if (driver != null)
            {
                txtId.Text = driver.Id;
                txtName.Text = driver.Name;
                txtBirthday.Value = driver.Birthday;
                txtPosition.Text = driver.Position;
                cbnp.Text = driver.NumberPlate;

                txtId.Enabled = false;

                ICoachRepository coachRepository = new CoachRepository();
                var numberPlates = coachRepository.GetAll()
                    .Select(c => c.NumberPlate)
                    .ToArray();
                cbnp.Items.AddRange(numberPlates);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driver = new Driver(
                    txtId.Text,
                    txtName.Text,
                    txtPosition.Text,
                    txtBirthday.Value,
                    cbnp.Text.Any() ? cbnp.Text : null
                );
                if (this.driver == null)
                    driverRepository.Add(driver);
                else driverRepository.Update(driver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }
    }
}
