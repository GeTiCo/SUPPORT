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
    /// Логика взаимодействия для PayOrder.xaml
    /// </summary>
    public partial class PayOrder : Window
    {
        public int SummaBankForOrder { get; set; } = App.SummaBankCard;
        List<Classes.ProductsInOrder> listProductsInOrders = MakeOrder.listProductsInOrders;

        public PayOrder()
        {
            InitializeComponent();
            SecretOrder.ItemsSource = MakeOrder.listProductsInOrders;
            clickbuy.Content = $"Оплатить: {App.SummaOrder}";
        }
        //Переход на главное окно
        private void BackOnMainWindow(object sender, RoutedEventArgs e)
        {
            App.SummaOrder = 0;
            App.Current.Windows[0].Title = "MainWindow";
            foreach (Window window in App.Current.Windows)
            {
                if (!(window is MainWindow))
                    window.Close();
            }
        }
        private void settingsorder(object sender, RoutedEventArgs e)
        {
            string name;
            int index;
            string doing = (sender as Button).Name;
            Classes.ProductsInOrder product = (sender as Button).DataContext as Classes.ProductsInOrder;

            int count, cost, newcosting;
            switch (doing)
            {
                case "plus":
                    count = product.Count;
                    cost = product.Cost;
                    if (App.SummaOrder + cost < SummaBankForOrder)
                    {
                        newcosting = (count + 1) * cost;
                        product.Costing = newcosting;
                        product.Count = count + 1;
                        App.SummaOrder += cost;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств");
                    }
                    break;
                case "minus":
                    count = product.Count;
                    cost = product.Cost;
                    if (count == 1)
                    {
                        name = product.Name;
                        App.SummaOrder -= cost;
                        index = MakeOrder.listProductsInOrders.FindIndex(x => x.Name == name);
                        MakeOrder.listProductsInOrders.RemoveAt(index);
                    }
                    else
                    {
                        newcosting = (count - 1) * cost;
                        product.Costing = newcosting;
                        product.Count = count - 1;
                        App.SummaOrder -= cost;
                    }
                    break;
                case "delete":
                    name = product.Name;
                    count = product.Count;
                    cost = product.Cost;
                    index = MakeOrder.listProductsInOrders.FindIndex(x => x.Name == name);
                    MakeOrder.listProductsInOrders.RemoveAt(index);
                    App.SummaOrder -= (cost * count);
                    break;
            }
            SecretOrder.Items.Refresh();
            clickbuy.Content = $"Оплатить: {App.SummaOrder}";
        }
        private void makeCheck(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
