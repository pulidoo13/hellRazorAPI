using Model.Comercial.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Comercial.Products
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Type Type { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public Supplier Supplier { get; set; }

        public DateTime CreationDate { get; set; }
        

    }
}
