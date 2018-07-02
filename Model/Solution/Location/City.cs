using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Solution.Geographic
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }      


        public State State { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
