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

namespace SrmEdu.WPF.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BorderDragMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ManuOpener_Click(object sender, RoutedEventArgs e)
        {
            ManuOpener.Visibility = Visibility.Collapsed;
            MenuCloser.Visibility = Visibility.Visible;
        }

        private void MenuCloser_Click(object sender, RoutedEventArgs e)
        {
            ManuOpener.Visibility = Visibility.Visible;
            MenuCloser.Visibility = Visibility.Collapsed;
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
