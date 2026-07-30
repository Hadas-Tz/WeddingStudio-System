using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class OrdersService
    {
        public static void AddOrders(Orders orders )
        {
            Globali.myDb.Orders.Add(orders);
            Globali.myDb.SaveChanges();
        }

        public static List<Orders> GetOrders()
        { return Globali.myDb.Orders.ToList(); }

        //עדכון הזמנה
        public static bool UpdateOrders()
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
            if (GetOrders().Count == 0)
                return 1;
            return GetOrders().Max(x => x.OrderCode) + 1;
        }
    }
}
