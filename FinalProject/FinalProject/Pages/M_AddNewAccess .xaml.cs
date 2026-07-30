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
    /// Interaction logic for M_AddNewAccess.xaml
    /// </summary>
    public partial class M_AddNewAccess : Window
    {
        Accessory a;
        bool flagUpdate;//דגל האם עדכון
        public M_AddNewAccess()
        {
            InitializeComponent();
            a = new Accessory();
            a.AccessoryCode=BL.AccessoryService.GetMaxCode();
            this.DataContext = a;
            Cac.ItemsSource = CategoryService.GetCategory();
            Cos.ItemsSource = SizeService.GetSize();
            flagUpdate = false;//במצב הוספה ולא עדכון
            a.Status= true;
        }
        public M_AddNewAccess(Accessory ac) : this()
        {
            this.a = ac;
            this.DataContext = null;
            this.DataContext = a;
            flagUpdate = true;//במצב עדכון ולא הוספה
            pc.Source = MyPicture.GetImage(a.Image);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a.Image = MyPicture.UploadImage_Dlg();
            pc.Source = MyPicture.GetImage(a.Image);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //לפני השמירה יש להוסיף מידות למוצר הספציפי
            Model.SizeAccess sa = new SizeAccess();
            //הכנסת ערכים
            sa.CodeSizeAccess = BL.SizeAccessService.GetMaxCode() +a.SizeAccess.Count;
            sa.CodeAccess = a.AccessoryCode;
            sa.Accessory = a;
            sa.Status = true;
            sa.Size = Cos.SelectedItem as Model.Size;
            sa.AmountStoke = Convert.ToInt32(asa.Text);
            //שמירת המידה למוצר
            a.SizeAccess.Add(sa);
            MessageBox.Show(" המידה נוספה");
            

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(ad) || Validation.GetHasError(ap) || Validation.GetHasError(asa))
                MessageBox.Show(" Error !!!!!!!");
            else
            {
                if (!flagUpdate)
                {
                    
                   
                    //אם יש כמה מידות צריך להוסיף כמה כאלו
                    //אחרי שגומר להוסיף את כל המידות שמירה סופית
                    AccessoryService.AddAccessory(a);
                }
                else
                {
                    this.DataContext = null;
                    this.DataContext = a;
                    if (AccessoryService.UpdateAccessory())
                    {
                        MessageBox.Show("עודכן בהצלחה");

                    }
                    else
                        MessageBox.Show("ERROR");

                   
                    //this.Hide();
                }
            }
            this.Close();
        }

    
    }
}
