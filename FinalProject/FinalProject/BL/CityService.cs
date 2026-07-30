using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class CityService
    {
        public static void AddCity(City city)
        {
            Globali.myDb.City.Add(city);
            Globali.myDb.SaveChanges();
        }

        public static List<City> GetCity()
        { return Globali.myDb.City.ToList(); }

        //עדכון עיר
        public static bool UpdateCity()
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
            if (GetCity().Count == 0)
                return 1;
            return GetCity().Max(x => x.CityCode) + 1;
        }
    }

}
