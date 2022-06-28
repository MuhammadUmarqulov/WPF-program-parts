using SrmEdu.WPF.Pages;
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

namespace SrmEdu.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserTerms_Click(object sender, RoutedEventArgs e)
        {
            SignInButton.Foreground = Brushes.White;
            SignInButton.BorderThickness = new Thickness(2);
            SignInButton.Background = new SolidColorBrush(Color.FromArgb(19,0x1E,38,0xFF));
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void UserTerms_Unchecked(object sender, RoutedEventArgs e)
        {
            SignInButton.BorderThickness = new Thickness(0);
            SignInButton.Background = new SolidColorBrush(Color.FromArgb(19, 0x1E, 38, 0xFF));
            SignInButton.Foreground = Brushes.White;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (PrivacyCheckBox.IsChecked == true)
            {
                var mainPage = new MainPage();
                mainPage.Show();
                this.Close();
            }
        }

        private void BorderDragMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
