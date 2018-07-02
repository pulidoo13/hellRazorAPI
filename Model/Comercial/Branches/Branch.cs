using Model.Comercial.Companies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace Model.Comercial.Branches
{
    [Table("Branches")]
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public string Email { get; set; }       
        
        public Company Company { get; set; }


        public DateTime CreationDate { get; set; }
            
        public byte[] Photo { get; set; }
    }
}
