using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class SizeAccessService
    {
        public static void AddSizeAccess(SizeAccess sizeAccess)
        {
            Globali.myDb.SizeAccess.Add(sizeAccess);
            Globali.myDb.SaveChanges();
        }

        public static List<SizeAccess> GetSizeAccess() { return Globali.myDb.SizeAccess.Where(x => x.Status == true).ToList(); }

        public static List<SizeAccess> GetSizeAccessAll() { return Globali.myDb.SizeAccess.ToList(); }
        //public static List<SizeAccess> GetSizeAccess()
        //{ return Globali.myDb.SizeAccess.ToList(); }

        //עדכון מידה
        public static bool UpdateSizeAccess()
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
            if (GetSizeAccessAll().Count == 0)
                return 1;
            return GetSizeAccessAll().Max(x => x.CodeSizeAccess) + 1;
        }
       
        public static bool DeleteStudent(SizeAccess sizeAccess)
        {
            try
            {
                sizeAccess.Status = false;
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
