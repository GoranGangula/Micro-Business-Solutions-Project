using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace LawOffice
{
    public class LOContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<UnderCase> UnderCases { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
