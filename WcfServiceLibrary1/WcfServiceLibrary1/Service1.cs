using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibrary1.Model;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        Model.MessageDBEntities MyDb=new MessageDBEntities();
        public bool AddMessages(Message msg)
        {
            try
            {
                MyDb.Message.Add(msg);
                MyDb.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false; 
            }
        }

        public int GetCode()
        {
            if(GetAllMessages().Count == 0)
                return 1;
            return GetAllMessages().Max(x => x.code) + 1;
               
        }

        public List<Message> GetAllMessages()
        {
            return MyDb.Message.ToList();
        }

        public List<Message> GetMessages(string idCust)
        {
            return MyDb.Message.Where(x=> x.CustId== idCust).ToList();
        }

        public bool SetStatus(Model.Message msg)
        {
            try
            {
               msg.Status = false;
                MyDb.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
               
        }
    }
}
