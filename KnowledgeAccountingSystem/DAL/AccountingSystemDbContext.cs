using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class AccountingSystemDbContext :IdentityDbContext<ApplicationUser>
    {

        public DbSet<KnowledgeArea> Areas { get; set; }

        public DbSet<KnowledgeSkill> Skills { get; set; }
        public AccountingSystemDbContext()
        {

        }
        public AccountingSystemDbContext(DbContextOptions<AccountingSystemDbContext> options):base(options)
        {
            
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<KnowledgeArea>().HasData(
                new KnowledgeArea {  Id=1, Name="Cloud Services" },
                new KnowledgeArea { Id=3, Name="Programming Languages" },
                new KnowledgeArea {Id=4, Name="Databases"});
            builder.Entity<IdentityRole>().HasData(new[]
            {
                new IdentityRole("user"),
                new IdentityRole("admin")
            });
            
        }
    }
}
