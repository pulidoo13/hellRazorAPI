using Model.Common;
using Model.Common;
using Model.Solution.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Comercial.Suppliers
{
    [Table("Suppliers")]
    public class Supplier
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        

        public Address Address { get; set; }

        public List<Phone> Phones { get; set; }
       

        public DateTime HireDate { get; set; }
       

        public DateTime CreationDate { get; set; }
    }
}
