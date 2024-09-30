using EasyCashIdentityProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DateAccessLayer.Concreate
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EasyCashDb; integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerAccountProcess>()
                .HasOne(X => X.SenderCustomer)
                .WithMany(y => y.CustomerSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CustomerAccountProcess>()
                 .HasOne(X => X.ReceiverCustomer)
                 .WithMany(y => y.CustomerReceiver)
                 .HasForeignKey(z => z.ReceiverID)
                 .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);

        }

    }
} 

