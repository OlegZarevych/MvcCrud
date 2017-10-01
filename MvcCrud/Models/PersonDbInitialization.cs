using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCrud.Models
{
    public class PersonDbInitialization : DropCreateDatabaseAlways<DataContext>
    {

            protected override void Seed(DataContext db)
            {
                db.Persons.Add(new Person {Name = "Oleg", LastName = "Zarevych", Age = 25, Time = DateTime.Now });

                base.Seed(db);
            }
        
    }
}