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
using MessageManager.ServiceReference1;

namespace MessageManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReference1.Service1Client sc;
        ServiceReference1.Message msg;
        public MainWindow()
        {
            InitializeComponent();
            sc = new ServiceReference1.Service1Client();
            msg = new ServiceReference1.Message();
            msg.code=sc.GetCode();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            msg.Status = true;
            msg.CustId = tb.Text;
            msg.Content = tb1.Text;
            if (sc.AddMessages(msg))
            {
                msg = new ServiceReference1.Message();
                tb.Text = "";
                tb1.Text = "";
                msg.code= sc.GetCode();
                MessageBox.Show("success!!");
            }
               

        }
    }
}
