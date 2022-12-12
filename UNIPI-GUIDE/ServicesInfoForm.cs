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
    public partial class ServicesInfoForm : Form
    {

        private String title;
        private int position;

        public ServicesInfoForm(String title, int position)
        {
            InitializeComponent();

            this.title = title;
            this.position = position;
        }

        private void ServicesInfoForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";
            saveIcon.ImageLocation = @"icons/save.png";

            formTitle.Text = title;

            getText(position);
        }

        private void getText(int position)
        {
            switch (position)
            {
                case 1:
                    {
                        loadTextFromFile("gunet.txt");
                        serviceInfoImg.ImageLocation = @"images/services/1.jpg";
                        break;
                    }
                case 2:
                    {
                        loadTextFromFile("secretary.txt");
                        serviceInfoImg.ImageLocation = @"images/services/2.jpg";
                        break;
                    }
                case 3:
                    {
                        loadTextFromFile("cslab.txt");
                        serviceInfoImg.ImageLocation = @"images/services/3.jpg";
                        break;
                    }
                case 4:
                    {
                        loadTextFromFile("library.txt");
                        serviceInfoImg.ImageLocation = @"images/services/4.jpg";
                        break;
                    }
                case 5:
                    {
                        loadTextFromFile("eudoxos.txt");
                        serviceInfoImg.ImageLocation = @"images/services/5.jpg";
                        break;
                    }
                case 6:
                    {
                        loadTextFromFile("helpdesk.txt");
                        serviceInfoImg.ImageLocation = @"images/services/6.jpg";
                        break;
                    }
                case 7:
                    {
                        loadTextFromFile("kepp.txt");
                        serviceInfoImg.ImageLocation = @"images/services/7.jpg";
                        break;
                    }
                case 8:
                    {
                        loadTextFromFile("website.txt");
                        serviceInfoImg.ImageLocation = @"images/services/8.jpg";
                        break;
                    }
                default:
                    {
                        loadTextFromFile("diasindesi.txt");
                        serviceInfoImg.ImageLocation = @"images/services/9.jpg";
                        break;
                    }
            }
        }

        private void loadTextFromFile(String filename)
        {
            String text = File.ReadAllText($"files\\services/{filename}", Encoding.UTF8);
            infoTxt.Text = text;
            infoTxt.BackColor = Color.White;
            infoTxt.ReadOnly = true;
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

        private void saveToTxtFile()
        {
            try
            {
                saveFileDialog1.Title = "Αποθήκευση Αρχείου";
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    infoTxt.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
