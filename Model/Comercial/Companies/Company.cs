using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Comercial.Companies
{
    [Table("Companies")]
    public class Company
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public string Email { get; set; }

        public string WebSite { get; set; }


        public DateTime CreationDate { get; set; }
    }
}
