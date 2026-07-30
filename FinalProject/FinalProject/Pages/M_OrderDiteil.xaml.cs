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
using System.Windows.Shapes;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_OrderDiteil.xaml
    /// </summary>
    public partial class M_OrderDiteil : Window
    {
        public M_OrderDiteil(Orders orders)
        {
            InitializeComponent();
            this.DataContext =orders;
            lvd.ItemsSource = orders.OrderDress.ToList();// BL.OrderDressService.GetOrderDress().Where(x => x.OrderCode == orders.OrderCode);
            lva.ItemsSource = orders.OrderAccess.ToList();//BL.OrderAccessService.GetOrderAccess().Where(x => x.OrderCode == orders.OrderCode);

        }
        private void CancelButton1(object sender, RoutedEventArgs e)
        {
            
                if (lvd.SelectedItem != null)
                {
                    OrderDress od = (OrderDress)lvd.SelectedItem;
                    MessageBoxResult answeare = MessageBox.Show(" ?האם אתה בטוח שברצונך למחוק את  השמלה", "", MessageBoxButton.YesNo);
                    if (answeare == MessageBoxResult.Yes)
                    {
                        OrderDressService.DeleteOrderDress(od);
                    }
                   
                }
                else
                    MessageBox.Show("בחר שמלה");

                //רענון של הליסט וויו
                lvd.ItemsSource = null;
                lvd.ItemsSource = OrderDressService.GetOrderDress();

           
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            if (lva.SelectedItem != null)
            {
                OrderAccess oa = (OrderAccess)lva.SelectedItem;
                MessageBoxResult answeare = MessageBox.Show(" ?האם אתה בטוח שברצונך למחוק את האביזר", "", MessageBoxButton.YesNo);
                if (answeare == MessageBoxResult.Yes)
                {
                    OrderAccessService.DeleteOrderAccess(oa);
                }
            }
            else
                MessageBox.Show("בחר אביזר");
            //רענון של הליסט וויו
            lvd.ItemsSource = null;
            lvd.ItemsSource = OrderAccessService.GetOrderAccess();
        }

       
    }

 }
