using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class DashboardForm : Form
    {
        private SoundPlayer player;
        private int position = 0;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            usernameTxt.Text = Program.getActiveUsername();

            playSoundBtn.ImageLocation = $@"icons/sound.png";

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            slideshow.ImageLocation = @"images/dashboard/dashboard_0.jpg";
            carouselTitle.Text = "TEDxUniversityOfPiraeus";

            pictureBox1.ImageLocation = @"images/dashboard/dashboard_mini_1.png";
            pictureBox2.ImageLocation = @"images/dashboard/dashboard_mini_2.png";
            pictureBox3.ImageLocation = @"images/dashboard/dashboard_mini_3.png";

            fbIcon.ImageLocation = @"icons/fb_icon.png";
            websiteIcon.ImageLocation = @"icons/website_icon.png";

            player = new SoundPlayer("sounds/unipi_guide_walkthrough.wav");
        }

        private void navAbout_Click(object sender, EventArgs e)
        {
            //Opens about the app form
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void navSyllabus_Click(object sender, EventArgs e)
        {
            SyllabusForm form = new SyllabusForm();
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
            else {
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

        private void navReviews_Click(object sender, EventArgs e)
        {
            //opens reviews form
            ReviewsForm form = new ReviewsForm();
            form.Show();
        }

        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            position++;

            if(position == 3)
            {
                position = 0;
            }

            switch (position)
            {
                case 0:
                    {
                        slideshow.ImageLocation = @"images/dashboard/dashboard_0.jpg";
                        carouselTitle.Text = "TEDxUniversityOfPiraeus";
                        break;
                    }
                case 1:
                    {
                        slideshow.ImageLocation = @"images/dashboard/dashboard_1.jpg";
                        carouselTitle.Text = "Αίθουσα διδασκαλίας στο Πανεπιστήμιο Πειραιώς";
                        break;
                    }
                case 2:
                    {
                        slideshow.ImageLocation = @"images/dashboard/dashboard_2.png";
                        carouselTitle.Text = "Πανεπιστήμιο Πειραιώς - Κτιριακό Συγκρότημα Νίκαιας";
                        break;
                    }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //first picture was clicked
            goToVideoForm(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //second picture was clicked
            goToVideoForm(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //third picture was clicked
            goToVideoForm(3);
        }

        private void goToVideoForm(int position )
        {
            VideoForm form = new VideoForm(position);
            form.Show();
        }

        private void fbIcon_Click(object sender, EventArgs e)
        {
            //open facebook
            System.Diagnostics.Process.Start("https://www.facebook.com/%CE%A0%CE%B1%CE%BD%CE%B5%CF%80%CE%B9%CF%83%CF%84%CE%AE%CE%BC%CE%B9%CE%BF-%CE%A0%CE%B5%CE%B9%CF%81%CE%B1%CE%B9%CF%8E%CF%82-212515515469805/");
        }

        private void websiteIcon_Click(object sender, EventArgs e)
        {
            //open website
            System.Diagnostics.Process.Start("https://cs.unipi.gr/index.php?lang=el");
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void playSoundBtn_Click(object sender, EventArgs e)
        {
            // play sound on click
            try
            {
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound");
            }
        }
    }
}
