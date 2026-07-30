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
using FinalProject.ServiceReference2;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : Page
    {
        Service1Client sc;
        public Message()
        {
            InitializeComponent();
            sc = new Service1Client();
            dg.ItemsSource = sc.GetAllMessages();
        }
    }
}
