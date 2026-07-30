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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for C_Feedback.xaml
    /// </summary>
    public partial class C_Feedback : Page
    {
        List<Feedback>  feedbacks = FeedbackService.GetFeedback();
        public C_Feedback()
        {
            InitializeComponent();
          feedbacks.ForEach(x => { allFeedbacks.Children.Add(new C_OneFeedback(x)); });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            A a = new A();
            NavigationService.Navigate(a);
        }
    }
}
