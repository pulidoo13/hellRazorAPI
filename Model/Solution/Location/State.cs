using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Solution.Geographic
{
    [Table("States")]
    public  class State
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public Country Country { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
