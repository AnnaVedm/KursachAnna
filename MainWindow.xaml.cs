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

namespace KursachAnna
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

      
            // Создаем и показываем модальное окно регистрации после загрузки главного окна
            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                // Создаем окно регистрации
                 Registrartion registrationWindow = new Registrartion();

                // Устанавливаем владельца
                registrationWindow.Owner = this;

                // Делаем окно модальным и отображаем его
                registrationWindow.ShowDialog();
            }
        

       
    }
}
