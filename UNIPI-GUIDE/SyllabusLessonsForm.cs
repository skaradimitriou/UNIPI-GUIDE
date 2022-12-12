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
    public partial class SyllabusLessonsForm : Form
    {

        private String semester;
        DataTable dt = new DataTable();

        public SyllabusLessonsForm(String semester)
        {
            InitializeComponent();

            this.semester = semester;
        }

        public SyllabusLessonsForm()
        {
            InitializeComponent();
        }

        private void SyllabusLessonsForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";
            saveIcon.ImageLocation = @"icons/save.png";

            String title = $"Μαθήματα {semester}' Εξαμήνου";

            formTitle.Text = title;

            getLessonsForSemester();
        }

        private void getLessonsForSemester()
        {
            String fileName = "";
            switch (semester)
            {
                case "Α":
                    {
                        fileName = "syllabus/a_semester.txt";
                        break;
                    }
                case "Β":
                    {
                        fileName = "syllabus/b_semester.txt";
                        break;
                    }
                case "Γ":
                    {
                        fileName = "syllabus/c_semester.txt";
                        break;
                    }
                default :
                    {
                        fileName = "syllabus/d_semester.txt";
                        break;
                    }
            }

            loadLessons(fileName);

            string line;
            StreamReader reader = new StreamReader("files\\" + fileName, Encoding.UTF8);

            dt.Columns.Add("Όνομα Μαθήματος", typeof(string));
            dt.Columns.Add("Κωδικός Μαθήματος", typeof(string));
            dt.Columns.Add("Είδος", typeof(string));

            while ((line = reader.ReadLine()) != null)
            {

                string[] words = line.Split('~');
                dt.Rows.Add(words[0], words[1], words[2]);

            }

            lessonsTable.DataSource = dt;
            lessonsTable.BackgroundColor = Color.White;
            lessonsTable.RowHeadersVisible = false;

            reader.Close();
        }

        private void loadLessons(String fileName)
        {
            String text = File.ReadAllText("files\\" + fileName, Encoding.UTF8);
            lessons.Text = text;
            lessons.BackColor = Color.White;
            lessons.ReadOnly = true;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveToTxtFile();
        }

        private void saveIcon_Click(object sender, EventArgs e)
        {
            saveToTxtFile();
        }

        private void saveToTxtFile()
        {
            try
            {
                saveFileDialog1.Title = "Αποθήκευση Αρχείου";
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lessons.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {
                saveLessons();
            }
            else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να σώσεις τις πληροφορίες, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
        }

        private void saveIcon_Click_1(object sender, EventArgs e)
        {
            Boolean isLoggedIn = Program.getLoggedInUser();
            if (isLoggedIn)
            {
                saveLessons();
            }
            else
            {
                //show messagebox that he needs to login.
                String title = "Προσοχή";
                String message = "Για να σώσεις τις πληροφορίες, θα πρέπει να έχεις εγγραφεί και συνδεθεί στον λογαριασμό σου. Ο λογαριασμός αυτός έχει δικαιώματα επισκέπτη.";

                MessageBox.Show(message, title);
            }
        }

        private void saveLessons()
        {
            try
            {
                saveFileDialog1.Title = "Αποθήκευση Αρχείου";
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lessons.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
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
