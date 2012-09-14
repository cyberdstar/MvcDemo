using System.Data.Entity;

namespace MvcDemo.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("name=ContactContext")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
