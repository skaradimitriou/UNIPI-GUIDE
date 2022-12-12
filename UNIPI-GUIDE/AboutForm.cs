using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";
            saveIcon.ImageLocation = @"icons/save.png";

            loadAboutText();
        }

        private void loadAboutText()
        {
            String text = File.ReadAllText("files\\about/about.txt", Encoding.UTF8);
            aboutUsText.Text = text;
            aboutUsText.BackColor = Color.White;
            aboutUsText.ReadOnly = true;
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

        private void navReviews_Click(object sender, EventArgs e)
        {
            ReviewsForm form = new ReviewsForm();
            form.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {
                saveToTxtFile();
            }
            else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να σώσεις τις πληροφορίες, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
        }

        private void saveIcon_Click(object sender, EventArgs e)
        {
            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {
                saveToTxtFile();
            }
            else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να σώσεις τις πληροφορίες, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
        }

        private void saveToTxtFile()
        {
            try
            {
                saveFileDialog1.Title = "Αποθήκευση Αρχείου";
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    aboutUsText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

    }
}
