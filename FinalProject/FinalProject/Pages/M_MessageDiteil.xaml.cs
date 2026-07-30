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
using FinalProject.ServiceReference2;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for M_MessageDiteil.xaml
    /// </summary>
    public partial class M_MessageDiteil : Window
    {
        public M_MessageDiteil(ServiceReference2.Message msg)
        {
            InitializeComponent();
            this.DataContext = msg;

        }
    }
}
