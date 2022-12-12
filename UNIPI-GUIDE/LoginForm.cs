using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UNIPI_GUIDE
{
    public partial class LoginForm : Form
    {
    
        private Boolean showPass = false;

        String connectionString = Program.getDbInfo();
        SQLiteConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            logoutIcon.ImageLocation = @"icons\logout.png";
            aboutBtn.ImageLocation = @"icons\info.png";

            loginBackground.ImageLocation = @"images\intro\unipi_bg.png";

            passwordInputField.PasswordChar = '*';
            showPassword.ImageLocation = @"icons\showPass.png";

            conn = new SQLiteConnection(connectionString);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // check for user input and procceed as logged in user
            String username = usernameInputField.Text;
            String password = passwordInputField.Text;

            conn.Open();

            String selectSQL = $"SELECT * FROM users WHERE username='{username}' AND password='{password}'";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //user has been logged in with credentials
                reader.Close();
                conn.Close();
                Program.setLoggedInUser(true);
                Program.setActiveUsername(username);
                goToDashboard();
            }
            else
            {
                /*
                 *  Credentials were invalid.. handling scenario.
                 */

                wrongCredentials.Visible = true;
                reader.Close();
                conn.Close();
            }
        }

        private void loginAsGuestBtn_MouseHover(object sender, EventArgs e)
        {
            loginAsGuestBtn.Font  = new Font(loginAsGuestBtn.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void loginAsGuestBtn_MouseLeave(object sender, EventArgs e)
        {
            loginAsGuestBtn.Font = new Font(loginAsGuestBtn.Font, FontStyle.Regular | FontStyle.Underline);
        }

        private void loginAsGuestBtn_Click(object sender, EventArgs e)
        {
            //saves to program that the user has skipped login with credentials
            Program.setLoggedInUser(false);
            goToDashboard();
        }

        private void goToDashboard()
        {
            DashboardForm form = new DashboardForm();
            this.Hide(); // closes login form before showing dashboard form
            form.ShowDialog();
            this.Show();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            showPass = !showPass;

            if (showPass)
            {
                passwordInputField.PasswordChar = '\0';
                showPassword.ImageLocation = @"icons\hidePass.png";
            } else
            {
                //hide password use case
                passwordInputField.PasswordChar = '*';
                showPassword.ImageLocation = @"icons\showPass.png";
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
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
