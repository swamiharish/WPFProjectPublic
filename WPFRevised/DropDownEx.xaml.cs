using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace WPFRevised
{
    /// <summary>
    /// Interaction logic for DropDownEx.xaml
    /// </summary>
    public partial class DropDownEx : Window, INotifyPropertyChanged
    {
        public DropDownEx()
        {
            InitializeComponent();
           
           
            Students = new ObservableCollection<student>()
            {
                new student { Name = "John", Age = 20, Gender = Gender.Male },
                new student { Name = "Alice", Age = 22, Gender = Gender.Female },
                new student { Name = "Bob", Age = 21, Gender = Gender.Male },
                new student { Name = "Eve", Age = 23, Gender = Gender.Female }
            };
           

            SelectedStudentDetails = Students[0];
            SelectedGender = Gender.Male; // Set default selected gender
            this.DataContext = this;

        }
        private Gender _selectedGender;
        public Gender SelectedGender
        {
            get { return _selectedGender; }
            set
            {
                _selectedGender = value;
                // Notify property changed if implementing INotifyPropertyChanged
            }
        }

        private ObservableCollection<student> _students;
        public ObservableCollection<student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                // Notify property changed if implementing INotifyPropertyChanged
            }
        }


        private student _selectedStudentDetails;
        public student SelectedStudentDetails
        {
            get { return _selectedStudentDetails; }
            set
            {
                _selectedStudentDetails = value;
                OnPropertyChanged(nameof(SelectedStudentDetails));
                // Notify property changed if implementing INotifyPropertyChanged
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }   

    public class student: INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        private Gender _gender;
        public Gender Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
    
    }
}
