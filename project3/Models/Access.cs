using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project3.Models
{
    public class Access
    {

        public int ID { get; set; }

        public int Level { get; set; }

        public string Description { get; set; }

        public DateTime DateIDK { get; set; }

        public double DoubleIDK { get; set; }

        public long LongIDK { get; set; }

        // one access can by assigned to many accounts
        public virtual ICollection<Account> Accounts { get; set; }

    }
}