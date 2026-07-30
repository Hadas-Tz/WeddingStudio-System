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
    /// Interaction logic for A.xaml
    /// </summary>
    public partial class A : Page
    {
        public A()
        {
            InitializeComponent();

            string videoPath = System.IO.Path.Combine(Environment.CurrentDirectory, "MyPicture", "סרטון.mp4");
            myVideo.Source = new Uri(videoPath, UriKind.Absolute);

            // התחלת הסרטון בפעם הראשונה בעת טעינת הדף
            myVideo.Play();

            // האירוע שלך - מחזיר להתחלה ומנגן שוב כשהסרטון מסתיים
            myVideo.MediaEnded += (s, e) =>
            {
                myVideo.Position = TimeSpan.Zero;
                myVideo.Play();
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if(pw.Visibility == Visibility.Collapsed) {  
            pw.Visibility = Visibility.Visible;
            cn.Visibility = Visibility.Visible;
            }
            else { 
            pw.Visibility = Visibility.Collapsed;
            cn.Visibility = Visibility.Collapsed;
            }
        }

        private void cn_Click(object sender, RoutedEventArgs e)
        {
            //if (pw.Password == "1234")
            {
                NavigationService.Navigate(new M_Menu());
            }
            //else
                //MessageBox.Show("הקוד שגוי");
        }

        private void katalogButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new C_Katalog());
        }

        private void feedback(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new C_Reply());
        }

        private void KesherButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new C_Kesher());
        }

        private void AboutMe(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new C_AboutMe());
        }
    }
}
