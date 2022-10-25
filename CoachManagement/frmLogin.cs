using DataAccess;
using Microsoft.VisualBasic.Logging;

namespace CoachManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool successed = Login.Authenticate(txtUsername.Text, txtPassword.Text);
            if (successed)
            {
                Hide();
                frmMain frmMain = new frmMain();
                frmMain.FormClosed += (sender, e) => Close();
                frmMain.ShowDialog();
            }
            else MessageBox.Show("Email or password is incorrect");
        }
    }
}