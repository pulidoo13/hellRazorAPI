using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Common
{
    [Table("Phones")]
    public class Phone
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }
        public TypePhone Type { get; set; }
        public bool IsEnabled  { get; set; }
    }
}
