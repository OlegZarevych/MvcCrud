using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrud.Models
{
    public class DataContextWrapper
    {
        private static DataContextWrapper instance;
        private static DataContext db = new DataContext();

        private DataContextWrapper()
        { }

        public static DataContextWrapper getInstance()
        {
            if (instance == null)
                instance = new DataContextWrapper();
            return instance;
        }

        public static Person FindId(int id)
        {
            Person p = db.Persons.Find(id);
            return p;
        }

        public static void AddPerson(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }

        public static void EditPerson(int id, Person person)
        {
            db.Entry(FindId(id)).CurrentValues.SetValues(person);
            db.SaveChanges();
        }

        public static void DeletePerson(int id)
        {
            db.Persons.Remove(FindId(id));
            db.SaveChanges();
        }

        public static IEnumerable<Person> GetPersons()
        {
            return db.Persons;
        }
    }
}