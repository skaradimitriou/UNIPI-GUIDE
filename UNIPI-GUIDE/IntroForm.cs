using System;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            logoutIcon.ImageLocation = @"icons\logout.png";
            aboutBtn.ImageLocation = @"icons\info.png";

            backgroundImg.ImageLocation = @"images\intro\unipi_bg.png";
            unipiLogo.ImageLocation = @"images\intro\unipi_logo.png";

            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.FlatAppearance.BorderSize = 0;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            /**
             * Opens the login form. The user can either login in with his credentials,
             * or log in as a user (with limited access to some forms).
             */

            LoginForm form = new LoginForm();
            this.Hide(); //Hide the intro form before showing the loginForm
            form.ShowDialog(); //show loginForm, code execution stop until loginForm is closed

            try
            {
                this.Show(); // when loginForm is closed, re-show introform.
            } catch(Exception exception)
            {
                Application.Exit();
            }
        }

        /**
         * Creates a hover effect with mouse. On mouse hover effect the width of thebutton is expanded
         * by 10 points, and when its gone it is shrinked by 10 points.
         */

        private void startBtn_MouseHover(object sender, EventArgs e)
        {
            startBtn.Width = startBtn.Width + 10;
        }

        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.Width = startBtn.Width - 10;
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            //saves to program that the user has skipped login with credentials
            Program.setLoggedInUser(false);

            AboutForm form = new AboutForm();
            this.Hide(); // closes login form before showing dashboard form
            form.ShowDialog();
            this.Show();
        }
    }
}
