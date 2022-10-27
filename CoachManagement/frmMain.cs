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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriver frmDriver = new frmDriver();
            frmDriver.MdiParent = this;
            frmDriver.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicket frmTicket = new frmTicket(null);
            frmTicket.MdiParent = this;
            frmTicket.Show();
        }
    }
}
