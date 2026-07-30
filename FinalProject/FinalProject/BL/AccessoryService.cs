using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class AccessoryService
    {
        public static void AddAccessory(Accessory  accessory)
        {
            Globali.myDb.Accessory.Add( accessory);
            Globali.myDb.SaveChanges();
        }

        public static List<Accessory> GetAccessory() { return Globali.myDb.Accessory.Where(x => x.Status == true).ToList(); }
        public static List<Accessory> GetAccessoryAll() { return Globali.myDb.Accessory.ToList(); }

        //public static List<Accessory> GetAccessory()
        //{ return Globali.myDb.Accessory.ToList(); }

        //עדכון מוצר
        public static bool UpdateAccessory()
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
            if (GetAccessoryAll().Count == 0)
                return 1;
            return GetAccessoryAll().Max(x => x.AccessoryCode) + 1;
        }
        
        //public static bool DeleteStudent(Accessory accessory)
        //{
        //    try
        //    {
        //        accessory.Status = false;
        //        Globali.myDb.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

    }

}
