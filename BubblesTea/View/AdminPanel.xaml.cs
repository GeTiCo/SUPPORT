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
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BackOnMainWindow(object sender, RoutedEventArgs e)
        {
            App.Current.Windows[0].Title = "MainWindow";
            foreach (Window window in App.Current.Windows)
            {
                if (!(window is MainWindow))
                    window.Close();
            }
        }
    }
}
