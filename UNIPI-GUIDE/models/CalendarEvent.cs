using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIPI_GUIDE
{
    public class CalendarEvent
    {

        public string date { get; set; }

        public string title { get; set; }
       

        public CalendarEvent(String date, String title)
        {
            this.date = date;
            this.title = title;
        }

        public String toCalendarFormat()
        {
            return $"Ημερομηνία: {date} ---- Περιγραφή: {title}";
        }
    }
}
