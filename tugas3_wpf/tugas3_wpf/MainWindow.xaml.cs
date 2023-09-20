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

namespace tugas3_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initially, show the LoginGrid and hide the SignUpGrid
            Log_in.Visibility = Visibility.Visible;
            Sign_up.Visibility = Visibility.Collapsed;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            // Show the LoginGrid and hide the SignUpGrid
            Log_in.Visibility = Visibility.Visible;
            Sign_up.Visibility = Visibility.Collapsed;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Show the SignUpGrid and hide the LoginGrid
            Sign_up.Visibility = Visibility.Visible;
            Log_in.Visibility = Visibility.Collapsed;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
