using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class FeedbackService
    {
        public static void AddFeedback(Feedback feedback)
        {
            Globali.myDb.Feedback.Add(feedback);
            Globali.myDb.SaveChanges();
        }

        public static List<Feedback> GetFeedback()
        { return Globali.myDb.Feedback.ToList(); }

        //עדכון תגובה
        public static bool UpdateFeedback()
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
            if (GetFeedback().Count == 0)
                return 1;
            return GetFeedback().Max(x => x.NumFeedback) + 1;
        }
    }
}
