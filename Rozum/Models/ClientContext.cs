using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rozum.Models
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}