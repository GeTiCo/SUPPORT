using System;
using System.Collections.Generic;
using System.IO;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace BubblesTea
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                App.excelApp = new Excel.Application();
                App.excelApp.Visible = false;
                if (File.Exists(App.fileMenu))
                {
                    App.excelWorkBook = App.excelApp.Workbooks.Open(App.fileMenu);
                    App.excelApp.Visible = false;
                }
                else
                {
                    MessageBox.Show("Файла с Excel не обнаружено");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dowload MS Office");
                this.Close();
            }
        }
        //Кнопка выхода
        private void Exit(object sender, RoutedEventArgs e)
        {
            App.excelApp.Quit();
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(App.excelApp);
            GC.Collect();
            System.Windows.Application.Current.Shutdown();
        }
        /*
        Кнопки переходов по экранам
        */
        //В каталог
        private void MoveCatalog(object sender, RoutedEventArgs e)
        {
            View.Catalog catalog = new View.Catalog();

            this.Hide();
            catalog.ShowDialog();
            this.Show();
        }
        //В формление заказа
        private void MoveMakeOrder(object sender, RoutedEventArgs e)
        {
            View.MakeOrder makeorder = new View.MakeOrder();

            this.Hide();
            makeorder.ShowDialog();
            this.Show();
        }
        //В редактирование
        private void MoveAdminLogIn(object sender, RoutedEventArgs e)
        {
            View.AdminLogIn adminlogin = new View.AdminLogIn();

            this.Hide();
            adminlogin.ShowDialog();
            this.Show();
        }
    }
}
