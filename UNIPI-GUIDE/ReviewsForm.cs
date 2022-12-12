using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using UNIPI_GUIDE.models;

namespace UNIPI_GUIDE
{
    public partial class ReviewsForm : Form
    {
        String connectionString = Program.getDbInfo();
        SQLiteConnection conn;

        List<Review> reviewsList = new List<Review>();


        public ReviewsForm()
        {
            InitializeComponent();
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";
            starIcon.ImageLocation = @"icons/star.png";

            conn = new SQLiteConnection(connectionString);
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

        private void getReviews()
        {
            reviewsList.Clear();
            int howManyReviews = 0;

            conn.Open();

            String selectSQL = "SELECT * FROM reviews ORDER BY username ASC";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            
            int sum = 0;

            while (reader.Read())
            {
                howManyReviews++;
                sum += reader.GetInt16(1);

                reviewsList.Add(new Review(reader.GetString(0), reader.GetInt16(1), reader.GetString(2)));
            }

            reader.Close();
            conn.Close();

            bindTextToScreen();

            reviewsTxt.BackColor = Color.White;
            reviewsTxt.ReadOnly = true;

            try
            {
                double averageRating = ((double)sum / (double)howManyReviews);
                averageRatingTxt.Text = averageRating.ToString() + "/5";
            }
            catch (Exception exception)
            {
                averageRatingTxt.Text = "X.X/5";
            }

            reviewsCounter.Text = howManyReviews.ToString();
        }

        private void bindTextToScreen()
        {
            reviewsTxt.Text = "";

            for (int i = 0; i < reviewsList.Count; i++)
            {
                String username = "Όνομα Χρήστη:" + " " + reviewsList[i].username;
                String grade = "Βαθμολογία:" + " " + reviewsList[i].grade;
                String description = Environment.NewLine + "Σχόλιο:" + " " + reviewsList[i].description + Environment.NewLine;
                String divider = "---------------" + Environment.NewLine;

                String line = username + "   " + grade + "   " + description + divider;

                reviewsTxt.AppendText(line);
            }
        }

        private void newReviewBtn_Click(object sender, EventArgs e)
        {
            /**
             * Opens new review form if the user has logged in successfully into the app
             */

            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {

                conn.Close();

                //open new review form
                NewReviewForm form = new NewReviewForm();
                form.Show();
            } else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να υποβάλλεις μια κριτική για το Τμήμα, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
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

        private void ReviewsForm_Activated(object sender, EventArgs e)
        {
            getReviews();
        }
    }
}
