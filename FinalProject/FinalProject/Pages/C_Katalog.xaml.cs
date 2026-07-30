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
    /// Interaction logic for C_Katalog.xaml
    /// </summary>
    public partial class C_Katalog : Page
    {
        int n;
        public C_Katalog()
        {
            InitializeComponent();
            Mfm.Navigate(new C_Dress());
        }

        private void pw_Click(object sender, RoutedEventArgs e)
        {
            A a = new A();
            NavigationService.Navigate(a);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (btnPrev != sender as Button)
            //{
            //    btnPrev.BorderBrush = (sender as Button).BorderBrush;
            //    btnPrev = sender as Button;
            //    ba.BorderBrush = btnPrev.BorderBrush;
            //    (sender as Button).BorderBrush = Brushes.Black;

                Mfm.Navigate(new C_Dress());
            //}
        }

        
        //private void Access(object sender, RoutedEventArgs e)
        //{
        //    if (btnPrev != null)
        //    {
        //        if (btnPrev != sender as Button)
        //        {
        //            btnPrev.BorderBrush = (sender as Button).BorderBrush;
        //            btnPrev = sender as Button;
        //            bd.BorderBrush = btnPrev.BorderBrush;
                  
        //            (sender as Button).BorderBrush = Brushes.Black;
        //        }

        //    }
        //    else
        //    {
        //        btnPrev = sender as Button;
        //        bd.BorderBrush = btnPrev.BorderBrush;
        //        (sender as Button).BorderBrush = Brushes.Black;
        //    }
        //    Mfm.Navigate(new C_Accessory());
        //}

        private void jewelry(object sender, RoutedEventArgs e)
        {
            n =2;
            Mfm.Navigate(new C_Accessory(n));
        }

        private void shoes(object sender, RoutedEventArgs e)
        {
          
            n = 1;
            Mfm.Navigate(new C_Accessory(n));
        }

        private void hair(object sender, RoutedEventArgs e)
        {
            n = 3;
            Mfm.Navigate(new C_Accessory(n));
        }
    }
}
