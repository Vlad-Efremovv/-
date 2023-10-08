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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        int way;
        public Page2(int way)
        {
            InitializeComponent();

            DGrid_BD.ItemsSource = POBEDA_BDEntities.GetContext().ArrayBD.ToList();

            this.way = way;
        }

        private void Edit_Colomn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btm_add_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new PageAdd());
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
