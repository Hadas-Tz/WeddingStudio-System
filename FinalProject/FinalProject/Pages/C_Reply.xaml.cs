using FinalProject.Model;
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

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for C_Reply.xaml
    /// </summary>
    public partial class C_Reply : Page
    {
        Feedback feedback;
        Clients client;
        string id;
        int userRating;

        public C_Reply()
        {
            InitializeComponent();
            feedback = new Feedback();
            this.DataContext = feedback;
            
        }
        //private void Rate_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    ////  מיקום הלחיצה על הפקד RATE
        //    // Point mousePosition = e.GetPosition(feedbackRating);

        //    //  //קבלת הערך שנבחר על ידי המשתמש
        //    //  userRating = (int)feedbackRating.Value;

        //    userRating = (int)feedbackRating.Value;
        //}

        //private void Rate_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    // מיקום הלחיצה על הפקד RATE
        //    Point mousePosition = e.GetPosition(feedbackRating);

        //    // קבלת הערך שנבחר על ידי המשתמש
        //    userRating = (int)feedbackRating.Value;

        //    // הצגת הערך שנבחר על ידי המשתמש
        //    MessageBox.Show($"Value: {userRating}");
        //}

        private void FeedbackRating_ValueChanged(object sender, HandyControl.Data.FunctionEventArgs<double> e)
        {
             userRating = (int) e.Info;
            feedback.Rating = userRating;

        }

        private void send(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(idc) || Validation.GetHasError(fc) )
                MessageBox.Show(" Error !!!!!!!");
            else 
            {
                id = idc.Text;
                client = ClientsService.GetClients().FirstOrDefault(x => x.Id == id);
                 if (client == null)
                    { MessageBox.Show(" הלקוח אינו קיים"); }
                 else
                 
                 {
                    if (feedback.Rating == 0 ) {
                        MessageBox.Show("דרג אותנו!!");
                    }
                    else { 
                    FeedbackService.AddFeedback(feedback);
                        MessageBox.Show( "התגובה נוספה... תודה על השיתוף!!");
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            C_Feedback feedback = new C_Feedback();
            NavigationService.Navigate(feedback);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            A a = new A();
            NavigationService.Navigate(a);
        }
    }
}
