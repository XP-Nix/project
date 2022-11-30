using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project3.Models
{
    public class project3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public project3Context() : base("name=project3Context")
        {
        }

        public System.Data.Entity.DbSet<project3.Models.Access> Accesses { get; set; }
        //public object Account_Card { get; internal set; }


        public System.Data.Entity.DbSet<project3.Models.Account> Accounts { get; set; }

        public System.Data.Entity.DbSet<project3.Models.Card> Cards { get; set; }
    }
}
