using System;
using System.Collections.Generic;
using System.Text;
using WPFMVVM.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WPFMVVM.Commands;

namespace WPFMVVM.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged 
    {


        private Person _person;

        public Person Person
        {
            get { return _person; }
            set
            {
               
                    _person = value;
                    OnPropertyChanged("Person");
                
            }
        }
        public RelayCommand AddPersonCommand { get; set; }
        public RelayCommand DeletePersonCommand { get; set; }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }
        public PersonViewModel()
        {
            Person = new Person() { Id = 1, Fname = "Harish", Lname = "Swami" };
            Persons = new ObservableCollection<Person>();
            AddPersonCommand = new RelayCommand(addPerson, canAddPerson);
            DeletePersonCommand = new RelayCommand(deletePerson, canDeletePerson);
        }


        private bool canAddPerson(object ?parameter)
        {
            return  (Person.Id==0 || Person.Id.ToString() == string.Empty) ? false: true && !string.IsNullOrWhiteSpace(Person.Fname) && !string.IsNullOrWhiteSpace(Person.Lname);
        }
        private void addPerson(object ? parameter)
            {
            Persons.Add(new Person() { Id = Person.Id, Fname = Person.Fname, Lname = Person.Lname, IsActive = Person.IsActive });
            Person.Id = Persons.Count + 1;
            Person.Fname = string.Empty;
            Person.Lname = string.Empty;
            OnPropertyChanged("Person");


        }  

        private bool canDeletePerson(object? parameter)
        {
            return true;
        }
        private void deletePerson(object? parameter)
        {
           // int id=(int)parameter;


            if (parameter is Person )
            {
                Person person= (Person)parameter;
                Persons.Remove(person);
            }
            Person.Id = Persons.Count + 1;
            OnPropertyChanged("Person");
        }

        public event PropertyChangedEventHandler ? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
