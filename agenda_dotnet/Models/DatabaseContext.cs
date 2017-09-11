using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace agenda_dotnet.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}