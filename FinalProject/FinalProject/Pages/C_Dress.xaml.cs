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
    /// Interaction logic for C_Dress.xaml
    /// </summary>
    public partial class C_Dress : Page
    {
       List<dress> dress=dressService.Getdress();

        public C_Dress()
        {
            InitializeComponent();
            dress.ForEach(x=> { alldress.Children.Add(new C_OneDress(x)); });   
        }
    }
}
