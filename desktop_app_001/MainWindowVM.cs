using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media.Imaging;


namespace desktop_app_001
{
    
    
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Person> people;

        [ObservableProperty]
        public Person selectedPerson = null;


        

        [RelayCommand]
        public void EditAPerson()
        {
            if(selectedPerson != null)
            {
                var vm = new Details_Adding_WindowVM(selectedPerson,ref people);
                
                Details_Adding_Window details_Adding_Window = new Details_Adding_Window(vm);
            
                details_Adding_Window.Show();
            }
            else
            {
                MessageBox.Show("Please select a student before editing.");
            }
           
        }

        [RelayCommand]
        public void AddAPerson()
        {
            if (selectedPerson != null)
            {
                selectedPerson = null;
                var vm = new Details_Adding_WindowVM(selectedPerson, ref people);

                Details_Adding_Window details_Adding_Window = new Details_Adding_Window(vm);
                details_Adding_Window.Show();

            }
            else
            {
                var vm = new Details_Adding_WindowVM(selectedPerson, ref people);

                Details_Adding_Window details_Adding_Window = new Details_Adding_Window(vm);
                details_Adding_Window.Show();
            }
                
        }


        [RelayCommand]
        public void DeleteStudent()
        {
            if (selectedPerson != null)
            {
                string name = selectedPerson.FirstName;
                people.Remove(selectedPerson);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Please Select Student before Delete.", "Error");


            }
        }







       


        public MainWindowVM()
        {
            people = new ObservableCollection<Person>();

            people.Add(new Person("Student1","Tom", "Jane","/Images/1.png", "22 nd May 1998", 3.25));
            people.Add(new Person("Student2", "Timmy", "Kal", "/Images/2.png", "14 th April May 1998", 2.17));
            people.Add(new Person("Student3", "Mari", "Samuwel", "/Images/3.png", "5 th June 1998", 3.38));
            people.Add(new Person("Student4", "Jecy", "Chan", "/Images/4.png", "24 th February 1998", 4.00));
            people.Add(new Person("Student5", "Sam", "Lapcy", "/Images/5.png", "18 th December 1998", 3.01));
            people.Add(new Person("Student6", "Lily", "Wikx", "/Images/6.png", "5 th August 1998", 2.29));


            
        }

    }
    
}
