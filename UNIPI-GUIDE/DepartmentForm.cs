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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            pictureBox1.ImageLocation = @"images/department/1.jpg";
            pictureBox2.ImageLocation = @"images/department/2.png";
            pictureBox3.ImageLocation = @"images/department/3.jpg";
            pictureBox4.ImageLocation = @"images/department/5.jpg";
            pictureBox5.ImageLocation = @"images/department/6.jpg";
            pictureBox6.ImageLocation = @"images/department/7.jpg";
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

        private void navSyllabus_Click(object sender, EventArgs e)
        {
            SyllabusForm form = new SyllabusForm();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // go to next form and pass title to be used as title in nextform
            goToDepartmentDetails("Insert title here", 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // go to next form and pass title to be used as title in nextform
            goToDepartmentDetails("Insert title here", 2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // go to next form and pass title to be used as title in nextform
            goToDepartmentDetails("Insert title here", 3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // go to next form and pass title to be used as title in nextform
            goToDepartmentDetails("Insert title here", 4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // go to next form and pass title to be used as title in nextform
            goToDepartmentDetails("Insert title here", 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // go to next form and pass title to be used as title in nextform
            goToDepartmentDetails("Insert title here", 6);
        }

        private void goToDepartmentDetails(String title, int position)
        {
            DepartmentDetailsForm form = new DepartmentDetailsForm(title, position);
            form.Show();
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

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            ServicesForm form = new ServicesForm();
            form.Show();
        }
    }
}
