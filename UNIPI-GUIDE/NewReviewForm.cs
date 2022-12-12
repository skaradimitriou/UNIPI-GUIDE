using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class NewReviewForm : Form
    {
        String connectionString = Program.getDbInfo();
        SQLiteConnection conn;

        public NewReviewForm()
        {
            InitializeComponent();
        }

        private void NewReviewForm_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);

            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";
        }

        private void navHome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
        }

        private void navCalendar_Click(object sender, EventArgs e)
        {
            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {
                //open calendar form
                CalendarForm form = new CalendarForm();
                form.Show();
            }
            else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να δεις το ημερολόγιο, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
        }

        private void navProfessors_Click(object sender, EventArgs e)
        {
            ProfessorsForm form = new ProfessorsForm();
            form.Show();
        }

        private void navDepartment_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.Show();
        }

        private void navSyllabus_Click(object sender, EventArgs e)
        {
            SyllabusForm form = new SyllabusForm();
            form.Show();
        }

        private void navAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void submitReviewBtn_Click(object sender, EventArgs e)
        {
            String userName = usernameTxt.Text;
            int rating = 0;
            String description = reviewsTxt.Text;

            Boolean validRating = false;

            try
            {
                rating = Int16.Parse(ratingTxt.Text);
                rateInputError.Visible = false;
                validRating = true;
            } catch(Exception exception)
            {
                rateInputError.Visible = true;
            }

            if(description.Length > 5)
            {
                tooManyCharsTxt.Visible = false;

                if (validRating)
                {
                    writeReview(userName, rating, description);
                }
            } else
            {
                tooManyCharsTxt.Visible = true;
            }
        }

        private void writeReview(String username, int rating, String ratingDescription)
        {
            conn.Open();

            String insertSQL = $"INSERT INTO reviews(username,grade,description) VALUES('{username}',{rating},'{ratingDescription}')";
            SQLiteCommand cmd = new SQLiteCommand(insertSQL, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Η κριτική σου αποθηκεύτηκε!");
                if (dialogResult == DialogResult.OK)
                {
                    Close();
                }
            }

            conn.Close();
        }

        private void reviewsTxt_TextChanged(object sender, EventArgs e)
        {
            reviewCharCounterTxt.Text = $"{reviewsTxt.Text.Length}/200";
        }

        private void returnToLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            askForLogout();
        }

        /**
         * Asks the user if he wants to logout.
         * If he clicks on Yes, the app closes, otherwise it resumes the user activity
         */

        private void askForLogout()
        {
            DialogResult dialogResult = MessageBox.Show("Είσαι σίγουρος οτι θέλεις να κλείσεις το UNIPI-GUIDE;", "Αποσύνδεση Χρήστη", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
