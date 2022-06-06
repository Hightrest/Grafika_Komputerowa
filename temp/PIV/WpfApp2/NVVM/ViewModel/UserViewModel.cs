using NVVM.Commands;
using NVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NVVM.ViewModel
{
    internal class UserViewModel :BaseViewModel
    {
        private User _user;

        public string FirstName
        {
            get { return _user.FirstName; }
            set
            {
                if(_user.FirstName != value)
                {
                    _user.FirstName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public string LastName
        {
            get { return _user.LastName; }
            set
            {
                if (_user.LastName != value)
                {
                    _user.LastName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - _user.BirthDate.Year;
                if (_user.BirthDate > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string FullName { get => $"{FirstName} {LastName}"; }

        public UserViewModel(User user)
        {
            _user = user;
            ClickCommand = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }

        public bool IsValid { get => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName); }

        private void DisplayMessage()
        {
            MessageBox.Show($"Welecome to the Simga's Chad Club {FirstName} {LastName}!", "The most pointless, unreasonable text message I could put here insted od 'Info'", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand ClickCommand
        {
            get;
            set;
        }
    }
}
