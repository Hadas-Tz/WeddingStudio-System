using FinalProject.BL;
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
using FinalProject.Model;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_Dress.xaml
    /// </summary>
    public partial class M_Dress : Page
    {
        public M_Dress()
        {
            InitializeComponent();
            lvd.ItemsSource = dressService.Getdress().OrderByDescending(x=> x.DressCode);

        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            //בדיקה אם אכן נבחר לקוח בליסטויו
            if (lvd.SelectedItem != null)
            {
                dress d = (dress)lvd.SelectedItem;
                M_AddNewDress Ad = new M_AddNewDress(d);
                Ad.ShowDialog();

            }
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            M_AddNewDress D = new M_AddNewDress();
            D.ShowDialog();
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            if (lvd.SelectedItem != null)
            {
                dress dress = (dress)lvd.SelectedItem;
                MessageBoxResult answeare = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הלקוח", "", MessageBoxButton.YesNo);
                if (answeare == MessageBoxResult.Yes)
                {
                    dressService.DeleteStudent(dress);
                }

                //רענון של הליסט וויו
                lvd.ItemsSource = null;
                lvd.ItemsSource = dressService.Getdress();

            }
        }
    }
}
