using KosTracker.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Data
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTRACKERWPF;Integrated Security=True;Encrypt=False");
        }

       //Add Tables
       public DbSet<User> Users { get; set; }
       public DbSet<Kosten> Kosten { get; set; }
       public DbSet<KostenSoll> kostenSoll {  get; set; }
    }
}
