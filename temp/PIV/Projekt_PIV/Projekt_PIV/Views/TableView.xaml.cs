using Projekt_PIV.Models;
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

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TableView.xaml
    /// </summary>
    public partial class TableView : UserControl
    {
        public List<Pracownicy> Pracownicylist { get; set; }

        public TableView()
        {
            InitializeComponent();

            ShowTable.ItemsSource = Pracownicylist;

        }
        //private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    textBox.Text = ShowTable.SelectedItem.ToString();
        //}
    }
}