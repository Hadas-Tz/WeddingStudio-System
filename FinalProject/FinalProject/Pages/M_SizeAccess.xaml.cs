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
using FinalProject.BL;
using FinalProject.Model;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_SizeAccess.xaml
    /// </summary>
    public partial class M_SizeAccess : Page
    {
        public M_SizeAccess()
        {
            InitializeComponent();
            lvas.ItemsSource = SizeAccessService.GetSizeAccess().OrderByDescending(x => x.CodeSizeAccess);
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            if (lvas.SelectedItem != null)
            {
                SizeAccess sa = (SizeAccess)lvas.SelectedItem;
                M_UpdateSizeAccess up = new M_UpdateSizeAccess(sa);
                up.ShowDialog();

            }
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            if (lvas.SelectedItem != null)
            {
                SizeAccess sizeAccess = (SizeAccess)lvas.SelectedItem;
                MessageBoxResult answeare = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הלקוח", "", MessageBoxButton.YesNo);
                if (answeare == MessageBoxResult.Yes)
                {
                   SizeAccessService.DeleteStudent(sizeAccess);
                }

                //רענון של הליסט וויו
                lvas.ItemsSource = null;
                lvas.ItemsSource = SizeAccessService.GetSizeAccess();

            }
        }
    }
}
