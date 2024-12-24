using DataLayer;
using Slide_7_Bai_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ContactServices
    {
        static IContactRepository repository;
        static ContactServices()
        {
            repository = new ContactRepository();
        }
        public static List<contact> GetAll()
        {
            return repository.GetAll();
        }
        public static contact GetById(int id)
        {
            return repository.GetById(id);
        }
        public static contact Insert(contact obj)
        {
            return repository.Insert(obj);
        }
        public static void Update(contact obj)
        {
            repository.Update(obj);
        }
        public static void Delete(contact obj)
        {
            repository.Delete(obj);
        }
    }
}
