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
    /// Interaction logic for C_OneDress.xaml
    /// </summary>
    public partial class C_OneDress : UserControl
    {
        public C_OneDress( dress d)
        {
            InitializeComponent();
            this.DataContext = d;
            this.Margin = new Thickness(3);
            pc.Source = MyPicture.GetImage(d.Image);

        }
    }
}
