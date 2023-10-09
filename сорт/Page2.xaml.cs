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

            this.way = way;
        }

        private void btm_add_Click(object sender, RoutedEventArgs e)
        {
            Menager.MainFrame.Navigate(new PageAdd(null));
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            var arrayForRemoving = DGrid_BD.SelectedItems.Cast<ArrayBD>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить Следующие данные {arrayForRemoving.Count()}", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    POBEDA_BDEntities.GetContext().ArrayBD.RemoveRange(arrayForRemoving);
                    POBEDA_BDEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удачно");

                    DGrid_BD.ItemsSource = POBEDA_BDEntities.GetContext().ArrayBD.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка выполнения операции");

                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            POBEDA_BDEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());

            DGrid_BD.ItemsSource = POBEDA_BDEntities.GetContext().ArrayBD.ToList();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Я пытался это сделать но у меня не получилось", "Мои оправдания");

            switch (way)
            {
                case 1:

                    //var arrayForRemoving = DGrid_BD.Items.Cast<ArrayBD>().ToList();

                    //int size = arrayForRemoving.Count;

                    //for (int j = 0; j < size; size--)// уменьшает шаги для сортировки
                    //{
                    //    for (int i = 0, y = 1; i < size; i++, y++) //пробегается и сравнивает
                    //    {

                    //        if (arrayForRemoving.ElementAt<ArrayBD>(i) > arrayForRemoving[y])
                    //        {
                    //            int temp = arrayForRemoving[i];
                    //            arrayForRemoving[i] = arrayForRemoving[y];
                    //            arrayForRemoving[y] = temp;
                    //        }
                    //    }
                    //}

                    break;

                default:
                    MessageBox.Show("Ты как смог это выгвать дурень", "ЧАВО");
                    break;
            }
        }
        
    }

}
