using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = this;

            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            lblValue.SetBinding(TextBlock.TextProperty, binding);
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Wpółrzędne kursora: ({e.GetPosition(this).X};{e.GetPosition(this).Y})");
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            var process = new ProcessStartInfo(e.Uri.AbsoluteUri);
            process.UseShellExecute = true;
            Process.Start(process);
            e.Handled=true;
        }

        //private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    TextBox textBox = sender as TextBox;
        //    txtStatus.Text="Selection starts at character #"+ textBox.SelectionStart+Environment.NewLine;

        //    txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;

        //    txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        //}
    }
}
