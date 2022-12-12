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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            pictureBox1.ImageLocation = @"images/services/1.jpg";
            pictureBox2.ImageLocation = @"images/services/2.jpg";
            pictureBox3.ImageLocation = @"images/services/3.jpg";
            pictureBox4.ImageLocation = @"images/services/4.jpg";
            pictureBox5.ImageLocation = @"images/services/5.jpg";
            pictureBox6.ImageLocation = @"images/services/6.jpg";
            pictureBox7.ImageLocation = @"images/services/7.jpg";
            pictureBox8.ImageLocation = @"images/services/8.jpg";
            pictureBox9.ImageLocation = @"images/services/9.jpg";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //gunet
            goToServiceDetails("GUNET", 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //e secretary
            goToServiceDetails("E - SECRETARY", 2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //cslab
            goToServiceDetails("CS LAB", 3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //library
            goToServiceDetails("Βιβλιοθήκη", 4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //eudoxos
            goToServiceDetails("Εύδοξος", 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //unipi helpdesk
            goToServiceDetails("Helpdesk", 6);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //gr diasindesis
            goToServiceDetails("Γραφείο Διασύνδεσης", 9);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //unipi website
            goToServiceDetails("Ιστοσελίδα Τμήματος", 8);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //kentro ereunwn
            goToServiceDetails("Κέντρο Ερευνών", 7);
        }

        private void goToServiceDetails(String title, int position)
        {
            ServicesInfoForm form = new ServicesInfoForm(title, position);
            form.Show();
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
