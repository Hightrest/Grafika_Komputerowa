using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Projekt_PIV.ViewModels;

namespace Projekt_PIV.Commands
{
    public class UpdateViewCommand : ICommand
    {

        private ProgramViewModel viewModel;

        public UpdateViewCommand(ProgramViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter.ToString() == "Główna")
            {
                viewModel.SelectedViewModel = new MainViewModel();
            }
            else if (parameter.ToString() == "Tabele")
            {
                viewModel.SelectedViewModel = new TableViewModel();
            }
            else if (parameter.ToString() == "Dodaj")
            {
                viewModel.SelectedViewModel = new AddViewModel();
            }
            else if (parameter.ToString() == "Usuń")
            {
                viewModel.SelectedViewModel = new DeleteViewModel();
            }
            else if (parameter.ToString() == "Modyfikuj")
            {
                viewModel.SelectedViewModel = new ModyfieViewModel();
            }
        }
    }
}
