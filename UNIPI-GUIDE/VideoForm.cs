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
    public partial class VideoForm : Form
    {
        private int position;

        public VideoForm(int position)
        {
            InitializeComponent();

            this.position = position;
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();
            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            playVideo(position);
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
            //Opens professors form
            ProfessorsForm form = new ProfessorsForm();
            form.Show();
        }

        private void navDepartment_Click(object sender, EventArgs e)
        {
            //opens department form
            DepartmentForm form = new DepartmentForm();
            form.Show();
        }

        private void navSyllabus_Click(object sender, EventArgs e)
        {
            //Opens about the syllabus form
            SyllabusForm form = new SyllabusForm();
            form.Show();
        }

        private void navReviews_Click(object sender, EventArgs e)
        {
            //opens reviews form
            ReviewsForm form = new ReviewsForm();
            form.Show();
        }

        private void navAbout_Click(object sender, EventArgs e)
        {
            //Opens about the app form
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void playVideo(int position)
        {

            string url = "";
            switch (position)
            {
                case 1:
                    {
                        url = "https://www.youtube.com/watch?v=Xbc84gLheDc";
                        formTitle.Text = "Πανεπιστήμιο Πειραιώς - Εικονική Περιήγηση";
                        break;
                    }

                case 2:
                    {
                        url = "https://www.youtube.com/watch?v=h5dU1oW3dCg&t=76s";
                        formTitle.Text = "Το πρόγραμμα Erasmus στο Πανεπιστήμιο Πειραιά";
                        break;
                    }
                default:
                    {
                        url = "https://www.youtube.com/watch?v=yR7Vg7viWkU";
                        formTitle.Text = "Τμήμα Πληροφορικής - Πανεπιστήμιο Πειραιώς";
                        break;
                    }
            }

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='400' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, url.Split('=')[1]);
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
