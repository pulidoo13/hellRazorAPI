using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Solution.Users
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }

        public int User_type { get; set; }


        public string Email { get; set; }

       
        public string TokenFacebook { get; set; }

      
        public string TokenGoogle { get; set; }

        public string FromApplication { get; set; }


        public DateTime CreationDate { get; set; }

    }
}
