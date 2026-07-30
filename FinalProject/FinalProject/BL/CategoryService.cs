using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class CategoryService
    {
        public static void AddCategory(Category category)
        {
            Globali.myDb.Category.Add(category);
            Globali.myDb.SaveChanges();
        }

        public static List<Category> GetCategory()
        { return Globali.myDb.Category.ToList(); }

        //עדכון קטגוריה
        public static bool UpdateCategory()
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
            if (GetCategory().Count == 0)
                return 1;
            return GetCategory().Max(x => x.CategoryCode) + 1;
        }
    }
}
