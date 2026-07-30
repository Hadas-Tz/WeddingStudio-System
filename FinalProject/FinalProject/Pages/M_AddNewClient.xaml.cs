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
using System.Xml.Linq;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_AddNewClient.xaml
    /// </summary>
    public partial class M_AddNewClient : Window
    {
        Clients c;
        bool flagUpdate;//דגל האם עדכון
        Clients cl;
        public M_AddNewClient()
        {
            InitializeComponent();
            c = new Clients();
            this.DataContext = c;
            Cmb.ItemsSource = CityService.GetCity();
            flagUpdate = false;//במצב הוספה ולא עדכון
        }
        public M_AddNewClient(Clients cl) : this()
        {
            this.c = cl;
            this.DataContext = null;
            this.DataContext = c;
            flagUpdate = true;//במצב עדכון ולא הוספה
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (Validation.GetHasError(Id) || Validation.GetHasError(fn) || Validation.GetHasError(ln) || Validation.GetHasError(st) || Validation.GetHasError(hn) || Validation.GetHasError(em) || Validation.GetHasError(pn))
                MessageBox.Show(" Error !!!!!!!");
            else
            {
                if (!flagUpdate)
                {
                    cl = ClientsService.GetClients().FirstOrDefault(x => x.Id == c.Id);
                    if (cl == null)
                     ClientsService.AddClient(c);
                    else
                      MessageBox.Show("הלקוח קיים");
                }
                else
                {
                    this.DataContext = null;
                    this.DataContext = c;
                    if (ClientsService.UpdateClient())
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
