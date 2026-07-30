using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using System.Windows.Controls;
using Microsoft.Win32;

namespace FinalProject.Pages
{
    public static class MyPicture
    {
        public static BitmapImage GetImage(string name)
        {
            if (name == null || name == "")
                return null;
            string path = Directory.GetCurrentDirectory();
            path = Directory.GetParent(Directory.GetParent(path).FullName).FullName + @"\MyPicture\" + name;
            if (File.Exists(path))//אם הקובץ לא קיים בתיקייה מקומית
            {
                return new BitmapImage(new Uri(path));
            }
            return null;
        }

      

        public static string UploadImage_Dlg()
        {
            string filename = null;
            // יצירת אוביקט שיודע לפתוח חלון 
            OpenFileDialog dlg = new OpenFileDialog();
            // קביעת מסנן לבחירת קובץ רק סיומות אלו יוכלו להיבחר 
            dlg.Filter = "All Images | *.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.png|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            //פותח חלונית בחירת תמונה ומחזיר האם נבחרה תמונה 
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)//אם לא לחץ ביטול
            {
                filename = dlg.SafeFileName;
                string path = Directory.GetCurrentDirectory();
                path = Directory.GetParent(Directory.GetParent(path).FullName).FullName + @"\MyPicture\" + dlg.SafeFileName;
                if (!File.Exists(path))
                {
                    File.Copy(dlg.FileName, path);//העתקת התמונה לתיקיה המקומית
                }
            }

            return filename;
        }
    }
}
