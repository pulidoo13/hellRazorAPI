using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Comercial.Services
{
    [Table("Services")]
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }
      

        public DateTime CreationDate { get; set; }
    }
}
