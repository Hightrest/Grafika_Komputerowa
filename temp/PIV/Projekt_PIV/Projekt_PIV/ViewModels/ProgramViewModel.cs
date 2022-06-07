using Projekt_PIV.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt_PIV.ViewModels
{
    public class ProgramViewModel :BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewModel
        { 
        get { return _selectedViewModel; }
        set {
                _selectedViewModel = value; 
                OnPropertyChange(nameof(SelectedViewModel));
            }
        }
        public ICommand UpdateViewCommand { get; set; }

        public ProgramViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
