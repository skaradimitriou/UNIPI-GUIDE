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
    public partial class CalendarForm : Form
    {
        List<CalendarEvent> userList = new List<CalendarEvent>();

        public CalendarForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = Program.getActiveUsername();

            userImg.ImageLocation = $@"icons/{Program.getUserPhoto()}";

            getAllEvents();
        }


        private void navHome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
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

        private void navAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void getEventsBtn_Click(object sender, EventArgs e)
        {
            String date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            String formattedDate = DateTime.Parse(date).ToString("dd/MM/yyyy");

            calendarEvents.Text = "";
            getEventsForDay(formattedDate.ToString());
        }

        private void getAllEvents()
        {
            String text = File.ReadAllText("files\\calendar/events.txt", Encoding.UTF8);
            calendarEvents.Text = text;
            calendarEvents.BackColor = Color.White;
            calendarEvents.ReadOnly = true;
        }
        private void getEventsForDay(String date)
        {
            userList.Clear();

            string line;
            int results = 0;
            StreamReader reader = new StreamReader("files\\calendar/events.txt", Encoding.UTF8);
            while ((line = reader.ReadLine()) != null)
            {
                
                string[] words = line.Split(',');

                if (words[0] == date)
                {
                    results++;
                    userList.Add(new CalendarEvent(words[0], words[1]));
                }
            }

            reader.Close();

            List<CalendarEvent> sorted = userList.OrderByDescending(x => x.date).ToList();

            String text = calendarEvents.Text;
            for (int i = 0; i < sorted.Count; i++)
            {
                text += i + 1 + ". " + sorted[i].toCalendarFormat() + "\n";
            }

            if(results == 0)
            {
                //no results found
                resultsFoundForEvents.Text = $"Δεν βρέθηκαν εκδηλώσεις για τις {date}";
            } else
            {
                // results found
                resultsFoundForEvents.Text = $"Βρέθηκαν {results} αποτελέσματα για τις {date}";
            }
            
            calendarEvents.Text = text;
        }

        private void getAllEventsBtn_Click(object sender, EventArgs e)
        {
            //gets all events available
            getAllEvents();

            resultsFoundForEvents.Text = "Εμφάνιση όλων των εκδηλώσεων";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            askForLogout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
