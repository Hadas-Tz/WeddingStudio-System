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
    /// Interaction logic for C_Accessory.xaml
    /// </summary>
    public partial class C_Accessory : Page
    {
        List<Accessory> access; /*= AccessoryService.GetAccessory();*/
        public C_Accessory(int n)
        {
            InitializeComponent();
            access = new List<Accessory>();
            Ac(n);
            //access.ForEach(x => { allAccess.Children.Add(new C_OneAccess(x)); });
        }
   
        public void Ac(int n)
        {
            if (n == 1)
            access = AccessoryService.GetAccessory().Where(x => x.Category1.CategoryCode == 1).ToList();
            if(n == 2)
            access = AccessoryService.GetAccessory().Where(x => x.Category1.CategoryCode== 2).ToList();
            if (n == 3)
            access = AccessoryService.GetAccessory().Where(x => x.Category1.CategoryCode == 3).ToList();
           
            access.ForEach(x => { allAccess.Children.Add(new C_OneAccess(x)); });
        }
    }
}
