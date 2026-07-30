using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class PaymentsService
    {
        public static void AddPayments(Payments  payments)
        {
            Globali.myDb.Payments.Add(payments);
            Globali.myDb.SaveChanges();
        }

        public static List<Payments> GetPayments()
        { return Globali.myDb.Payments.ToList(); }

        //עדכון תשלום
        public static bool UpdatePayments()
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
            if (GetPayments().Count == 0)
                return 1;
            return GetPayments().Max(x => x.PaymentCode) + 1;
        }
    }
}
