using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class SyllabusForm : Form
    {
        public SyllabusForm()
        {
            InitializeComponent();
        }

        private void SyllabusForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            aSemesterArrow.ImageLocation = @"icons/arrow_right.png";
            bSemesterArrow.ImageLocation = @"icons/arrow_right.png";
            cSemesterArrow.ImageLocation = @"icons/arrow_right.png";
            dSemesterArrow.ImageLocation = @"icons/arrow_right.png";
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

        private void navReviews_Click(object sender, EventArgs e)
        {
            ReviewsForm form = new ReviewsForm();
            form.Show();
        }

        private void navAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void semesterAtxt_Click(object sender, EventArgs e)
        {
            //open a semester lessons
            openLessons("Α");
        }

        private void semesterBtxt_Click(object sender, EventArgs e)
        {
            //open b semester lessons
            openLessons("Β");
        }

        private void semesterCtxt_Click(object sender, EventArgs e)
        {
            //open c semester lessons
            openLessons("Γ");
        }

        private void semesterDtxt_Click(object sender, EventArgs e)
        {
            //open d semester lessons
            openLessons("Δ");
        }

        private void openLessons(String semester)
        {
            SyllabusLessonsForm form = new SyllabusLessonsForm(semester);
            form.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //open a semester lessons
            openLessons("Α");
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            //open b semester lessons
            openLessons("Β");
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            //open c semester lessons
            openLessons("Γ");
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            //open d semester lessons
            openLessons("Δ");
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
