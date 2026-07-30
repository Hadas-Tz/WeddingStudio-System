
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
    /// Interaction logic for C_AboutMe.xaml
    /// </summary>
    public partial class C_AboutMe : Page
    {
        public C_AboutMe()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            A a = new A();
            NavigationService.Navigate(a);
        }
    }
}
