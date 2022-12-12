using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIPI_GUIDE.models
{
    public class Professor
    {
        public string fullName { get; set; }
        public string title { get; set; }
        public string office { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string imageUrl { get; set; }

        public string gender { get; set; }

        public Professor(String fullName, String title, String office, String telephone, String email, String imageUrl, String gender)
        {
            this.fullName = fullName;
            this.title = title;
            this.office = office;
            this.telephone = telephone;
            this.email = email;
            this.imageUrl = imageUrl;
            this.gender = gender;
        }
    }
}
