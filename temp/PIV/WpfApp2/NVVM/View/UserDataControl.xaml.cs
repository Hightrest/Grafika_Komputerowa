using NVVM.Model;
using NVVM.ViewModel;
using System;
using System.Collections.Generic;
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

namespace NVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy UserDataControl.xaml
    /// </summary>
    public partial class UserDataControl : UserControl
    {
        private readonly UserViewModel _viewModel;
        public UserDataControl()
        {
            InitializeComponent();
            var model = new User
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = new DateTime(1990, 7, 30)
            };
            _viewModel = new UserViewModel(model);
            DataContext = _viewModel;
        }
    }
}