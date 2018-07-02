using Model.Comercial.Branches;
using Model.Common;
using Model.Common.Preferences;
using Model.Common;
using Model.Common.Preferences;
using Model.Solution.Location;
using Model.Solution.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Model.Dates;

namespace Model.Comercial.Customers
{
    [Table("Customers")]
    public class Customer
    {
        public Customer() {
           
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

        public Address Address { get; set; }

        public List<Phone> Phones { get; set; }

        public DateTime BornDate { get; set; }

        public Preference Preference { get; set; }

        public Branch Branch { get; set; }

       
        public DateTime CreationDate { get; set; }

        public virtual List<Date> Dates{get;set;}

        
    }
}
