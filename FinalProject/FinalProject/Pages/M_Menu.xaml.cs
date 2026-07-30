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
    /// Interaction logic for M_Menu.xaml
    /// </summary>
    public partial class M_Menu : Page
    {
        public M_Menu()
        {
            
            InitializeComponent();
            Mfm.Navigate(new M_Clients());

           
        }

        private void ClientButton(object sender, RoutedEventArgs e)
        {
            if (btnPrev != sender as Button)
            {
                btnPrev.BorderBrush = (sender as Button).BorderBrush;
                btnPrev = sender as Button;
                bd.BorderBrush = btnPrev.BorderBrush;
                ba.BorderBrush = btnPrev.BorderBrush;
                bo.BorderBrush = btnPrev.BorderBrush;
                bas.BorderBrush = btnPrev.BorderBrush;
                bm.BorderBrush = btnPrev.BorderBrush;
                (sender as Button).BorderBrush = Brushes.Black;
            }

            Mfm.Navigate(new M_Clients());
        }

        Button btnPrev=null;
        private void DressButton(object sender, RoutedEventArgs e)
        {
            if (btnPrev != null)
            {
                if (btnPrev != sender as Button) { 
                 btnPrev.BorderBrush = (sender as Button).BorderBrush;
                btnPrev = sender as Button;
                bc.BorderBrush = btnPrev.BorderBrush;
                ba.BorderBrush = btnPrev.BorderBrush;
                bo.BorderBrush = btnPrev.BorderBrush;
                bas.BorderBrush = btnPrev.BorderBrush;
                bm.BorderBrush = btnPrev.BorderBrush;
                    (sender as Button).BorderBrush = Brushes.Black;}
                
            }
            else
            {
                btnPrev = sender as Button;
                bc.BorderBrush = btnPrev.BorderBrush;
                ba.BorderBrush = btnPrev.BorderBrush;
                bo.BorderBrush = btnPrev.BorderBrush;
                bas.BorderBrush = btnPrev.BorderBrush;
                bm.BorderBrush = btnPrev.BorderBrush;
                (sender as Button).BorderBrush = Brushes.Black;
            }
            Mfm.Navigate(new M_Dress());
        }

          
      

        private void  AccessButton(object sender, RoutedEventArgs e)
        {
            //if (btnPrev != null)
            //{
            //    if (btnPrev != sender as Button)
            //        btnPrev.BorderBrush = (sender as Button).BorderBrush;
            //}
            //    btnPrev = sender as Button;
            //    bc.BorderBrush = btnPrev.BorderBrush;
            //    bd.BorderBrush = btnPrev.BorderBrush;
            //    bo.BorderBrush = btnPrev.BorderBrush;
            //(sender as Button).BorderBrush = Brushes.Black;
            if (btnPrev != null)
            {
                if (btnPrev != sender as Button)
                {
                    btnPrev.BorderBrush = (sender as Button).BorderBrush;
                    btnPrev = sender as Button;
                    bc.BorderBrush = btnPrev.BorderBrush;
                    bd.BorderBrush = btnPrev.BorderBrush;
                    bo.BorderBrush = btnPrev.BorderBrush;
                    bas.BorderBrush = btnPrev.BorderBrush;
                    bm.BorderBrush = btnPrev.BorderBrush;
                    (sender as Button).BorderBrush = Brushes.Black;
                }

            }
            else
            {
                btnPrev = sender as Button;
                bc.BorderBrush = btnPrev.BorderBrush;
                bd.BorderBrush = btnPrev.BorderBrush;
                bo.BorderBrush = btnPrev.BorderBrush;
                bas.BorderBrush = btnPrev.BorderBrush;
                bm.BorderBrush = btnPrev.BorderBrush;
                (sender as Button).BorderBrush = Brushes.Black;
            }
            Mfm.Navigate(new M_Accessory());
        }

        private void OrderButton(object sender, RoutedEventArgs e) 
        {
            if (btnPrev != null)
            {
                if (btnPrev != sender as Button)
                {
                    btnPrev.BorderBrush = (sender as Button).BorderBrush;
                    btnPrev = sender as Button;
                    bc.BorderBrush = btnPrev.BorderBrush;
                    bd.BorderBrush = btnPrev.BorderBrush;
                    ba.BorderBrush = btnPrev.BorderBrush;
                    bas.BorderBrush = btnPrev.BorderBrush;
                    bm.BorderBrush = btnPrev.BorderBrush;
                    (sender as Button).BorderBrush = Brushes.Black;
                }

            }
            else
            {
                btnPrev = sender as Button;
                bc.BorderBrush = btnPrev.BorderBrush;
                bd.BorderBrush = btnPrev.BorderBrush;
                ba.BorderBrush = btnPrev.BorderBrush;
                bas.BorderBrush = btnPrev.BorderBrush;
                bm.BorderBrush = btnPrev.BorderBrush;
                (sender as Button).BorderBrush = Brushes.Black;
            }
            Mfm.Navigate(new M_Orders());
        }



        private void SizeAccess(object sender, RoutedEventArgs e)
        {
            if (btnPrev != null)
            {
                if (btnPrev != sender as Button)
                {
                    btnPrev.BorderBrush = (sender as Button).BorderBrush;
                    btnPrev = sender as Button;
                    bc.BorderBrush = btnPrev.BorderBrush;
                    bd.BorderBrush = btnPrev.BorderBrush;
                    ba.BorderBrush = btnPrev.BorderBrush;
                    bo.BorderBrush = btnPrev.BorderBrush;
                    bm.BorderBrush = btnPrev.BorderBrush;
                    (sender as Button).BorderBrush = Brushes.Black;
                }

            }
            else
            {
                btnPrev = sender as Button;
                bc.BorderBrush = btnPrev.BorderBrush;
                bd.BorderBrush = btnPrev.BorderBrush;
                ba.BorderBrush = btnPrev.BorderBrush;
                bo.BorderBrush = btnPrev.BorderBrush;
                bm.BorderBrush = btnPrev.BorderBrush;
                (sender as Button).BorderBrush = Brushes.Black;
            }
          
            Mfm.Navigate(new M_SizeAccess());
        }

        private void pw_Click(object sender, RoutedEventArgs e)
        {
            A a = new A();
            NavigationService.Navigate(a);
        }

        private void AsksButton(object sender, RoutedEventArgs e)
        {
            if (btnPrev != null)
            {
                if (btnPrev != sender as Button)
                {
                    btnPrev.BorderBrush = (sender as Button).BorderBrush;
                    btnPrev = sender as Button;
                    bc.BorderBrush = btnPrev.BorderBrush;
                    bd.BorderBrush = btnPrev.BorderBrush;
                    ba.BorderBrush = btnPrev.BorderBrush;
                    bo.BorderBrush = btnPrev.BorderBrush;
                    bas.BorderBrush = btnPrev.BorderBrush;
                    (sender as Button).BorderBrush = Brushes.Black;
                }

            }
            else
            {
                btnPrev = sender as Button;
                bc.BorderBrush = btnPrev.BorderBrush;
                bd.BorderBrush = btnPrev.BorderBrush;
                ba.BorderBrush = btnPrev.BorderBrush;
                bo.BorderBrush = btnPrev.BorderBrush;
                bas.BorderBrush = btnPrev.BorderBrush;
                (sender as Button).BorderBrush = Brushes.Black;
            }
            Mfm.Navigate(new Message());
        }
    }
}
