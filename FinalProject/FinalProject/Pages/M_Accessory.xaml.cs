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
using FinalProject.BL;


namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_Accessory.xaml
    /// </summary>
    public partial class M_Accessory : Page
    {
        public M_Accessory()
        {
            InitializeComponent();
            lva.ItemsSource = AccessoryService.GetAccessory().OrderByDescending(x => x.AccessoryCode);
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            M_AddNewAccess D = new M_AddNewAccess();
            D.ShowDialog();
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            //בדיקה אם אכן נבחר לקוח בליסטויו
            if (lva.SelectedItem != null)
            {
                Accessory a = (Accessory)lva.SelectedItem;
                M_AddNewAccess Ac = new M_AddNewAccess(a);
                Ac.ShowDialog();

            }
        }

        //private void CancelButton(object sender, RoutedEventArgs e)
        //{
        //    if (lva.SelectedItem != null)
        //    {
        //        Accessory accessory = (Accessory)lva.SelectedItem;
        //        MessageBoxResult answeare = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הלקוח", "", MessageBoxButton.YesNo);
        //        if (answeare == MessageBoxResult.Yes)
        //        {
        //            AccessoryService.DeleteStudent(accessory);
        //        }

        //        //רענון של הליסט וויו
        //        lva.ItemsSource = null;
        //        lva.ItemsSource = AccessoryService.GetAccessory();
        //    }
        //}
    }
}
