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
using System.Windows.Shapes;

namespace BubblesTea.View
{
    /// <summary>
    /// Логика взаимодействия для AdminLogIn.xaml
    /// </summary>
    public partial class AdminLogIn : Window
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }
        //Переход на главное окно
        private void BackOnMainWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MoveOnAdminPanel(object sender, RoutedEventArgs e)
        {
            View.AdminPanel adminpanel = new View.AdminPanel();
            this.Hide();
            adminpanel.ShowDialog();
        }
    }
}
