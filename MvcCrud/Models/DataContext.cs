using System.Data.Entity;

namespace MvcCrud.Models
{
    public class DataContext : DbContext
    {
            public DbSet<Person> Persons { get; set; }
    }
}