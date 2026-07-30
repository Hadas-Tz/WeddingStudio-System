using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class SizeService
    {
        public static void AddSize(Size size)
        {
            Globali.myDb.Size.Add(size);
            Globali.myDb.SaveChanges();
        }

        public static List<Size> GetSize()
        { return Globali.myDb.Size.ToList(); }

        //עדכון מידה
        public static bool UpdateSize()
        {
            try
            {
                Globali.myDb.SaveChanges();
                return true;//אם העדכון הצליח מחזיר
            }
            catch (Exception)
            {
                return false; //אם לא הצליח מחזיר
            }
        }
    }
}
