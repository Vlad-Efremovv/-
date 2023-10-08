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

namespace сорт
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Btn_Bubbles_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new Page2(1));
        }

        private void Btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new Page2(2));
        }

        private void Btn_Choice_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new Page2(3));
        }

        private void Btn_Fast_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new Page2(4));
        }

        private void Btn_Merger_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new Page2(5));
        }

        private void Btn_Shaker_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new Page2(6));
        }
    }
}
