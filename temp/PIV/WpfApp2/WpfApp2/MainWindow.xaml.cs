using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _students = new ObservableCollection<Student>()
            {
                new Student{Name="Jan", Surname="Kowalski"},
                new Student{Name="Józef", Surname="Cieszyński"},
                new Student{Name="Stanisław", Surname="Zamorski"},
                new Student{Name="Jerzy", Surname="Piwnik"},
        };
        NamesListBox.ItemsSource = _students;
        }

        private ObservableCollection<Student> _students;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _students.Add(new Student { Name = "Jan", Surname = Guid.NewGuid().ToString() });
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (NamesListBox.SelectedItem != null)
            {
                var student = NamesListBox.SelectedItem as Student;
                student.Name = "Karzimierz";
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if(NamesListBox.SelectedItem != null)
            {
                var student = NamesListBox.SelectedItem as Student;
                _students.Remove(student);
            }
        }
    }

    public class Student : INotifyPropertyChanged
    {
        public string Name
        {
            get => Name;
            set
            {
                if (Name != value)
                {
                    Name = value;
                    INotifyPropertyChanged("Name");
                    INotifyPropertyChanged("FullName");
                }
            }
        }
        public string Surname
        {
            get => Surname;
            set
            {
                if (Surname != value)
                {
                    Surname = value;
                    INotifyPropertyChanged("Surname");
                    INotifyPropertyChanged("FullName");
                }
            }
        }
        public string FullName { get=>$"{Name} {Surname}"; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void INotifyPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
