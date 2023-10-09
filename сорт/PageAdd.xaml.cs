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
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        private ArrayBD CreateNum = new ArrayBD();

        public PageAdd(ArrayBD arrayBD)
        {
            InitializeComponent();

            if (arrayBD!=null)
            {
                CreateNum = arrayBD;
            }

            DataContext = CreateNum;
        }


        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            POBEDA_BDEntities.GetContext().ArrayBD.Add(CreateNum);

            try
            {
                POBEDA_BDEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена", "Успех");

                Menager.MainFrame.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("В ходе выполнения сохранения возникла ошибка", "Ошибка");
            }
        }

        
    }
}
