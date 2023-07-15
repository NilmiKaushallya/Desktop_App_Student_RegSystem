using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace desktop_app_001
{
    public partial class Details_Adding_WindowVM : ObservableObject
    {
        [ObservableProperty]
        public string studentNo;

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string dob;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string img;


        public Person Personperson=null;

        ObservableCollection<Person> people= new ObservableCollection<Person>();

        
        public  Details_Adding_WindowVM(Person p, ref ObservableCollection<Person> Persons)
        {
            people = Persons;
            if (p != null)
            {
               studentNo= p.StudentNo;
                firstname = p.FirstName;
                lastname = p.LastName;
                dob = p.DateOfBirth;
                gpa = p.GpaValue;
                img = p.ImageThumbnail;
                Personperson = p;
            }
            //MessageBox.Show("const");
        }



        [RelayCommand]
        public void Upload()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                Img = dialog.FileName;
                //MessageBox.Show(ImgUrl);
            }
        }






       public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {
            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error");
                return;
            }


            if (Personperson != null)
            {
                people[people.IndexOf(Personperson)] = new Person(StudentNo,Firstname, Lastname, Dob, Gpa, Img);
                //edit
            }
            else
            {
                people.Add(new Person(StudentNo ,Firstname,Lastname,Dob,Gpa,Img));
                
            }

          
                CloseAction();
          
            Application.Current.MainWindow.Show();
         


        }

    }
}
