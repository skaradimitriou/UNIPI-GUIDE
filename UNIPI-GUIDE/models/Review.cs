using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIPI_GUIDE.models
{
    public class Review
    {

        public string username { get; set; }
        public int grade { get; set; }
        public string description { get; set; }

        public Review(string username, int grade, string description)
        {
            this.username = username;
            this.grade = grade;
            this.description = description;
        }
    }
}
