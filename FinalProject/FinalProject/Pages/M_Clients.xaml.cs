using FinalProject.BL;
using HandyControl.Expression.Shapes;
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
using System.Xml.Linq;
using FinalProject.Model;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_Clients.xaml
    /// </summary>
    public partial class M_Clients : Page
    {
        public M_Clients()
        {
            InitializeComponent();

            lvc.ItemsSource = ClientsService.GetClients();

            //Cmb1.ItemsSource = CityService.GetCity();
        }
        
        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            //בדיקה אם אכן נבחר לקוח בליסטויו
            if (lvc.SelectedItem != null)
            {
                Clients cl = (Clients)lvc.SelectedItem;
                M_AddNewClient B = new M_AddNewClient(cl);
                B.ShowDialog();
              
                //רענון של הליסט וויו
                lvc.ItemsSource = null;
                lvc.ItemsSource = ClientsService.GetClients();

            }
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            M_AddNewClient B= new M_AddNewClient();
            B.ShowDialog();

        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            if (lvc.SelectedItem != null)
            {
                Clients cl = (Clients)lvc.SelectedItem;
                MessageBoxResult answeare = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הלקוח", "", MessageBoxButton.YesNo);
                if (answeare == MessageBoxResult.Yes)
                {
                    ClientsService.DeleteStudent(cl);
                }

                //רענון של הליסט וויו
                lvc.ItemsSource = null;
                lvc.ItemsSource = ClientsService.GetClients();

            }



           
        }
    }
}
