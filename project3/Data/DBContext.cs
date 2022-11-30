using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;
using project3.Models;

namespace project3.Data
{
    public class DBContext : DbContext      // OLD STUFF !!!!
    {

        public DBContext() : base("DBContext")
        {
        }

        public DbSet<Access> Accesses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<Account_Card> Account_Cards { get; set; }
        public DbSet<Card> Cards { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Account_Card>().HasKey(ac => new
        //    {
        //        ac.AccountID,
        //        ac.CardID
        //    });
        //    modelBuilder.Entity<Account_Card>().HasOptional(c => c.Card).WithMany(ac => ac.Account_Card).HasForeignKey(c => c.CardID);
         //   modelBuilder.Entity<Account_Card>().HasOptional(c => c.Account).WithMany(ac => ac.Account_Card).HasForeignKey(c => c.AccountID);
//
        //    base.OnModelCreating(modelBuilder);
       // }
    }

}