using Model.Comercial.Branches;
using Model.Common;
using Model.Common.Preferences;
using Model.Solution.Location;
using Model.Solution.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Comercial.Employees
{
    [Table("Employees")]
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

        public Address Address { get; set; }

        public List<Phone> Phones { get; set; }

        public DateTime BornDate { get; set; }

        public DateTime HireDate { get; set; }

        public Branch Branch { get; set; }

        public Preference Preference { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
