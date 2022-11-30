using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace project3.Models
{
    public class Account
    {

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public double Rank { get; set; }

        public long LongIDK { get; set; }


        // one account can have Many cards
        //public List<Account_Card> Account_Card { get; set; }

        // one account can have one access level
        public int AccessID { get; set; }
        [ForeignKey("AccessID")]
        public Access Access { get; set; }

    }
}