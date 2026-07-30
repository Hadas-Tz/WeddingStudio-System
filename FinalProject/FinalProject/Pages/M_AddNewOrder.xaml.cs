using FinalProject.BL;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for M_AddNewOrder.xaml
    /// </summary>
    public partial class M_AddNewOrder : Window
    {
        Orders o;
        bool flagUpdate;//דגל האם עדכון
        Clients c;
        dress dress;
        OrderDress dr;
        OrderAccess ac;
        Payments p;
        SizeAccess  sizeAccess;
        string d;
        int sumd=0;
        int suma=0;
        int oc;
        DateTime date;
        Orders dateo;

        public M_AddNewOrder()
        {
            InitializeComponent();
            o = new Orders();
            o.OrderCode = BL.OrdersService.GetMaxCode();
            this.DataContext = o;
            flagUpdate = false;//במצב הוספה ולא עדכון
            o.Date = DateTime.Now;
            
            
        }

        public M_AddNewOrder(Orders orders) : this()
        {
            this.o = orders;
            this.DataContext = null;
            this.DataContext = o;
            flagUpdate = true;//במצב עדכון ולא הוספה
           
        }
        
       //הוספת שמלה
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //האם קיים הקוד שמלה
            string cd = dro.Text;
            dress = BL.dressService.Getdress().FirstOrDefault(x => x.DressCode.ToString() == cd);
            if (dress == null) { MessageBox.Show(" קוד השמלה אינו תקין");}
            
            else
            {
                dr = o.OrderDress.FirstOrDefault(x => x.DressCode.ToString() == cd);
                if (dr != null) { MessageBox.Show(" שמלה קיימת בהזמנה"); }
                
                else { 
                Model.OrderDress od = new OrderDress();
                //הכנסת ערכים
                od.Code = BL.OrderDressService.GetMaxCode() + o.OrderDress.Count;
                od.OrderCode = o.OrderCode;
                od.DressCode = dress.DressCode;
                od.Price = dress.Price;
                od.Status = true;
                od.Orders = o;
                od.dress = dress;
                //שמירת השמלה להזמנה
                o.OrderDress.Add(od);
                MessageBox.Show(" השמלה נוספה בהצלחה");
                }

            }
        }
        //הוספת אביזר
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //לפני השמירה יש להוסיף את האביזר להזמנה
            //האם קיים קוד מוצר
            string ca = ao.Text;
            sizeAccess = BL.SizeAccessService.GetSizeAccess().FirstOrDefault(x => x.CodeSizeAccess.ToString() == ca);
            if (sizeAccess == null) { MessageBox.Show(" קוד האביזר אינו תקין");  }

            else
            {
                ac = o.OrderAccess.FirstOrDefault(x => x.AcccessoryCode.ToString() == ca);
                if (ac != null) { MessageBox.Show(" אביזר קיים בהזמנה"); }

                else
                {
                    Model.OrderAccess ora = new OrderAccess();
                    ora.Code = BL.OrderAccessService.GetMaxCode() + o.OrderAccess.Count;
                    ora.OrderCode = o.OrderCode;
                    ora.AcccessoryCode = sizeAccess.CodeAccess;
                    ora.Price = sizeAccess.Accessory.Price;
                    ora.Status = true;
                    ora.SizeAccess = sizeAccess;
                    ora.Orders = o;
                    o.OrderAccess.Add(ora);
                    MessageBox.Show(" האביזר נוסף בהצלחה");
                }
            }
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          if (Validation.GetHasError(id) || Validation.GetHasError(ao) || Validation.GetHasError(dro)  || Validation.GetHasError(np))
                MessageBox.Show(" Error !!!!!!!");
          else
           {
             if (!flagUpdate)   //הוספה
             { 
                //לפני השמירה יש לבדוק אם הת.ז קיים במערכת
                d = id.Text;
                c = BL.ClientsService.GetClients().FirstOrDefault(x => x.Id == d);
                if (c == null) { MessageBox.Show(" הלקוח אינו קיים"); }

               else
                {
                   if (dp.SelectedDate <= DateTime.Now) { MessageBox.Show(" התאריך אינו תקין"); }
                    else
                     {
                          o.Clients = c;
                            //תשלומים
                          p = new Payments();
                          p.PaymentCode = BL.PaymentsService.GetMaxCode() + o.Payments.Count;
                          p.OrderCode= o.OrderCode;
                            //סכימה של כל מחירי השמלות והאביזרים
                            oc = o.OrderCode;
                            sumd = o.OrderDress.Sum(x => x.Price);
                            suma = o.OrderAccess.Sum(x => x.Price);
                           
                            p.Total= suma + sumd;
                            o.Total=p.Total;
                            if (a.IsChecked==true) { p.MethodPayment = "מזומן"; }
                            if (b.IsChecked == true) { p.MethodPayment = "העברה בנקאית"; }
                            if (t.IsChecked == true) { p.MethodPayment = "צ'ק"; }
                            p.NumPayment = (int)Convert.ToInt64(np.Text);
                            p.Orders = o;
                            o.Payments.Add(p);
                           
                            date = o.Date;
                          

                            OrdersService.AddOrders(o);
                    }
                }
             }
             else
             {

                    this.DataContext = null;
                    this.DataContext = o;
                    if (AccessoryService.UpdateAccessory())
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
