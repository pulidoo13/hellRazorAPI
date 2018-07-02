using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Common.Preferences
{
    [Table("Preferences")]
    public class Preference
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
