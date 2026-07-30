using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class OrderDressService
    {
        public static void AddOrderDress(OrderDress orderDress)
        {
            Globali.myDb.OrderDress.Add(orderDress);
            Globali.myDb.SaveChanges();
        }
        public static List<OrderDress> GetOrderDress() { return Globali.myDb.OrderDress.Where(x => x.Status == true).ToList(); }
        //public static List<OrderDress> GetOrderDress()
        //{ return Globali.myDb.OrderDress.ToList(); }

        //עדכון שמלה בהזמנה
        public static bool UpdateOrderDress()
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
            if (GetOrderDress().Count == 0)
                return 1;
            return GetOrderDress().Max(x => x.Code) + 1;
        }


        public static bool DeleteOrderDress(OrderDress orderDress)
        {
            try
            {
                orderDress.Status = false;
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