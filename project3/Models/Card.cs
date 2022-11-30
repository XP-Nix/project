using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace project3.Models
{
    public class Card
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(160)]
        public string CardName { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }

        public double CardRank { get; set; }

        public int Points { get; set; }

        public long LongIDK { get; set; }

        //many to many
        //one acc can have many cards
        //one card can be used by multiple people

        //idk anymore (╯°□°）╯︵ ┻━┻
        //public List<Account_Card> Account_Card { get; set; }

    }
}