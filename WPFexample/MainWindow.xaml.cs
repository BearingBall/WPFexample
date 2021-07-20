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

namespace WPFexample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_1_Enter(object sender, RoutedEventArgs e)
        {
            Btn_1.Background = System.Windows.Media.Brushes.Red;
        }

        private void Btn_2_Enter(object sender, RoutedEventArgs e)
        {
            Btn_2.Background = System.Windows.Media.Brushes.Red;
        }

        private void Btn_3_Enter(object sender, RoutedEventArgs e)
        {
            Btn_3.Background = System.Windows.Media.Brushes.Red;
        }

        private void Btn_1_Leave(object sender, RoutedEventArgs e)
        {
            Btn_1.Background = System.Windows.Media.Brushes.Black;
        }

        private void Btn_2_Leave(object sender, RoutedEventArgs e)
        {
            Btn_2.Background = System.Windows.Media.Brushes.Black;
        }

        private void Btn_3_Leave(object sender, RoutedEventArgs e)
        {
            Btn_3.Background = System.Windows.Media.Brushes.Black;
        }

        private void Btn_3_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
