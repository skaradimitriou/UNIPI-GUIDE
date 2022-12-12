using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class RegisterForm : Form
    {

        String connectionString = Program.getDbInfo();
        SQLiteConnection conn;

        public RegisterForm()
        {
            InitializeComponent();

            logoutIcon.ImageLocation = @"icons\logout.png";
            aboutBtn.ImageLocation = @"icons\info.png";

            registerBackground.ImageLocation = @"images\intro\unipi_bg.png";
            passwordInputField.PasswordChar = '*';
            confPasswordInputField.PasswordChar = '*';
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameInputField.Text;
            String password = passwordInputField.Text;
            String confirmPassword = confPasswordInputField.Text;

            if (password == confirmPassword)
            {
                wrongPasswords.Visible = false;

                if (username.Length > 3)
                {
                    //username at least 4 chars length

                    saveUserToDatabase(username, password);
                }
            } else
            {
                // passwords do not match
                wrongPasswords.Visible = true;
            }
        }

        private void saveUserToDatabase(String name,String pass)
        {
            conn.Open();

            String insertSQL = $"INSERT INTO users(username,password) VALUES('{name}','{pass}')";
            SQLiteCommand cmd = new SQLiteCommand(insertSQL, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Η εγγραφή σου ολοκληρώθηκε!");
                if (dialogResult == DialogResult.OK)
                {
                    Close();
                }
            }

            conn.Close();
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
