using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace desktop_app_001
{
    public class Person
    {
        public string StudentNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageThumbnail { get; set; }
        public string DateOfBirth { get; set; }
        public double GpaValue { get; set; }


        public string ImageUrl
        {
            get { return $"/Images/{ImageThumbnail}"; }
        }

        public Person(string studentNo, string firstName, string lastName, string imageThumbnail, string dateOfBirth, double gpaValue)
        {
            StudentNo = studentNo;
            FirstName = firstName;
            LastName = lastName;
            ImageThumbnail = imageThumbnail;
            DateOfBirth = dateOfBirth;
            GpaValue = gpaValue;
        }

        public Person(string studentNo ,string firstName, string lastName, string dateOfBirth, double gpaValue, string imageThumbnail)
        {
            StudentNo=studentNo;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            GpaValue = gpaValue;
            ImageThumbnail = imageThumbnail;
        }
    }
}
