using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    internal class ClientsService
    {
        public static void AddClient(Clients client)
        {
            Globali.myDb.Clients.Add(client);
            Globali.myDb.SaveChanges();
        }
        public static List<Clients> GetClients() { return Globali.myDb.Clients.Where(x => x.Status == true).ToList(); }

       
      
        //עדכון לקוח
        public static bool UpdateClient()
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

        public static bool DeleteStudent(Clients client)
        {
            try
            {
                client.Status = false;
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

