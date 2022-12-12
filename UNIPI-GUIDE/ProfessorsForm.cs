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
using UNIPI_GUIDE.models;

namespace UNIPI_GUIDE
{
    public partial class ProfessorsForm : Form
    {
        List<Professor> professorList = new List<Professor>();
        DataTable dt = new DataTable();

        public ProfessorsForm()
        {
            InitializeComponent();

            saveSmallIcon.ImageLocation = @"icons/save.png";
        }

        private void ProfessorsForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            loadProfessors();

            getProfessors();
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

        private void navAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void loadProfessors()
        {
            String text = File.ReadAllText("files\\professors/professors.txt", Encoding.UTF8);
            richTextBox1.Text = text;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ReadOnly = true;
        }

        private void getProfessors()
        {
            string line;
            StreamReader reader = new StreamReader("files\\professors/professors.txt", Encoding.UTF8);

            dt.Columns.Add("Ονοματεπώνυμο", typeof(string));
            dt.Columns.Add("Γραφείο", typeof(string));
            dt.Columns.Add("Τηλέφωνο", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));

            while ((line = reader.ReadLine()) != null)
            {

                string[] words = line.Split('~');
                dt.Rows.Add(words[0], words[2], words[3], words[4]);
                
                professorList.Add(new Professor(words[0], words[1], words[2], words[3], words[4], words[5], words[6]));
               
            }

            professorsTable.DataSource = dt;
            professorsTable.BackgroundColor = Color.White;
            professorsTable.RowHeadersVisible = false;

            reader.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {
                saveProfessorsToTxt();
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
                saveProfessorsToTxt();
            }
            else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να σώσεις τις πληροφορίες, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
        }

        private void saveProfessorsToTxt()
        {
            try
            {
                saveFileDialog1.Title = "Αποθήκευση Αρχείου";
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
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
