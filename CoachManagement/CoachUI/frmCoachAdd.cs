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
using System.Xml.Linq;

namespace CoachManagement.CoachUI
{
    public partial class frmCoachAdd : Form
    {
        private Coach? coach;

        private ICoachRepository coachRepository = new CoachRepository();
        public frmCoachAdd(Coach? coach)
        {
            InitializeComponent();
            this.coach = coach; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Coach coach = new Coach(
                    txtNumberPlate.Text,
                    int.Parse(txtSeat.Text),
                    cbStatus.Checked,
                    txtBrand.Text,
                    txtLocation.Text
                );
                if (this.coach == null)
                    coachRepository.Add(coach);
                else coachRepository.Update(coach);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }

        private void frmCoachAdd_Load(object sender, EventArgs e)
        {
            txtLocation.Items.AddRange(City.Get());

            if (coach != null)
            {
                txtNumberPlate.Text = coach.NumberPlate;
                txtSeat.Text = coach.Seats.ToString();
                txtBrand.Text = coach.Brand;
                txtLocation.Text = coach.Location;
                txtNumberPlate.Enabled = false;
                cbStatus.Checked = coach.Active;
            }
        }
    }
}
