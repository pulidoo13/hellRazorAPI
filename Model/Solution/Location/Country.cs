using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Solution.Geographic
{
    [Table("Countries")]
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsEnabled { get; set; }


        public DateTime CreationDate { get; set; }
    }
}
