using FinalProject.BL;
using FinalProject.Model;
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

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_Orders.xaml
    /// </summary>
    public partial class M_Orders : Page
    {
        List<Orders> ol;
        DateTime dt;
        public M_Orders()
        {
            InitializeComponent();
            lvo.ItemsSource = OrdersService.GetOrders().OrderByDescending(x => x.OrderCode);

        }

       

        private void AllButton(object sender, RoutedEventArgs e)
        {
            if (lvo.SelectedItem != null) { 
            Orders o = (Orders)lvo.SelectedItem;
            M_OrderDiteil od = new M_OrderDiteil(o);
            od.ShowDialog();
            }
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            M_AddNewOrder order = new M_AddNewOrder();
            order.Show();
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            if (lvo.SelectedItem != null)
            {
                Orders o = (Orders)lvo.SelectedItem;
                M_AddNewOrder Ao = new M_AddNewOrder(o);
                Ao.Show();

            }
        }

        private void f_Checked(object sender, RoutedEventArgs e)
        {
            if (f.IsChecked == true)
            {
                dt = DateTime.Now;
                ol = OrdersService.GetOrders().Where(x => x.Date < dt).ToList();
                lvo.ItemsSource = ol.OrderByDescending(x => x.OrderCode);
            }
        }

        private void t_Checked(object sender, RoutedEventArgs e)
        {
            if (t.IsChecked == true)
            {
                dt = DateTime.Now;
                ol = OrdersService.GetOrders().Where(x => x.Date >= dt).ToList();
                lvo.ItemsSource = ol.OrderByDescending(x => x.OrderCode);
            }
        }

        private void all_Checked(object sender, RoutedEventArgs e)
        {
            if (all.IsChecked == true)
             lvo.ItemsSource = OrdersService.GetOrders().OrderByDescending(x => x.OrderCode);

        }

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (t.IsChecked == true) { 
        //        dt = DateTime.Now;
        //    ol = OrdersService.GetOrders().Where(x => x.Date >= dt).ToList();
        //    lvo.ItemsSource = ol.OrderByDescending(x => x.OrderCode);
        //    }
        //    else
        //        lvo.ItemsSource = OrdersService.GetOrders().OrderByDescending(x => x.OrderCode);

        //}

        //private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        //{
        //    if (f.IsChecked == true) { 
        //        dt = DateTime.Now;
        //        ol = OrdersService.GetOrders().Where(x => x.Date >= dt).ToList();
        //        lvo.ItemsSource = ol.OrderByDescending(x => x.OrderCode);
        //    }
        //    else
        //        lvo.ItemsSource = OrdersService.GetOrders().OrderByDescending(x => x.OrderCode);
        //}
    }
}
