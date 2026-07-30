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
    /// Interaction logic for M_AddNewDress.xaml
    /// </summary>
    public partial class M_AddNewDress : Window
    {
        dress d;
        bool flagUpdate;//דגל האם עדכון
        public M_AddNewDress()
        {
            InitializeComponent();
            d=new dress();
            d.DressCode = BL.dressService.GetMaxCode();
            this.DataContext = d;
            csd.ItemsSource = SizeService.GetSize();
            flagUpdate = false;//במצב הוספה ולא עדכון
            d.Status = true;
        }
        public M_AddNewDress(dress dr) : this()
        {
            this.d = dr;
            this.DataContext = null;
            this.DataContext = d;
            flagUpdate = true;//במצב עדכון ולא הוספה
            pc.Source = MyPicture.GetImage(d.Image);
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( Validation.GetHasError(dd) || Validation.GetHasError(cd) || Validation.GetHasError(ld) || Validation.GetHasError(pd) )
                MessageBox.Show(" Error !!!!!!!");
            else
            {
                if (!flagUpdate)
                {
                   dressService.Adddress(d);
                }
                else
                {
                    this.DataContext = null;
                    this.DataContext = d;
                  
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            d.Image = MyPicture.UploadImage_Dlg();
            pc.Source = MyPicture.GetImage(d.Image);
        }
    }
}
