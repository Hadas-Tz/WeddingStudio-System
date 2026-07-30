using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class OrderAccessService
    {
        public static void AddOrderAccess(OrderAccess orderAccess)
        {
            Globali.myDb.OrderAccess.Add(orderAccess);
            Globali.myDb.SaveChanges();
        }
        public static List<OrderAccess> GetOrderAccess() { return Globali.myDb.OrderAccess.Where(x => x.Status == true).ToList(); }
        //public static List<OrderAccess> GetOrderAccess()
        //{ return Globali.myDb.OrderAccess.ToList(); }

        //עדכון איזר בהזמנה
        public static bool UpdateOrderAccess()
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
            if (GetOrderAccess().Count == 0)
                return 1;
            return GetOrderAccess().Max(x => x.Code) + 1;
        }
        public static bool DeleteOrderAccess(OrderAccess orderAccess)
        {
            try
            {
                orderAccess.Status = false;
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
