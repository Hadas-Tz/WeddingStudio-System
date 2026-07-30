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
using System.Windows.Shapes;
using FinalProject.BL;
using FinalProject.Model;


namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_UpdateSizeAccess.xaml
    /// </summary>
    public partial class M_UpdateSizeAccess : Window
    {
        public M_UpdateSizeAccess(SizeAccess sizeAccess) 
        {
            InitializeComponent();
            this.DataContext=sizeAccess;
            Cos.ItemsSource = SizeService.GetSize();
            pc.Source = MyPicture.GetImage(sizeAccess.Accessory.Image);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(asa))
                MessageBox.Show(" Error !!!!!!!");
            else
            {
          
                {
                    this.DataContext = null;
                    

                    if (dressService.Updatedress())
                    {
                        MessageBox.Show("עודכן בהצלחה");

                    }
                    else
                        MessageBox.Show("ERROR");
                }
            }
            this.Close();
        }
    }
}
