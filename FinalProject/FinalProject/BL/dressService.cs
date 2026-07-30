using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class dressService
    {
        public static void Adddress(dress  d)
        {
            Globali.myDb.dress.Add(d);
            Globali.myDb.SaveChanges();
        }

        public static List<dress> Getdress() { return Globali.myDb.dress.Where(x => x.Status == true).ToList(); }

        public static List<dress> GetdressAll() { return Globali.myDb.dress.ToList(); }
        //public static List<dress> Getdress()
        //public static List<dress> Getdress()
        //{ return Globali.myDb.dress.ToList(); }

        //עדכון שמלה
        public static bool Updatedress()
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

        public static int GetMaxCode()
        {
            if (GetdressAll().Count == 0)
                return 1;
            return GetdressAll().Max(x => x.DressCode) + 1;
        }

        public static bool DeleteStudent(dress dress)
        {
            try
            {
               dress.Status = false;
                Globali.myDb.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

