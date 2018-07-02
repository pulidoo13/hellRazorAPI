using Model.Comercial.Branches;
using Model.Comercial.Customers;
using Model.Comercial.Employees;
using Model.Comercial.Services;
using Model.Solution.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Dates
{
    [Table("Dates")]
    public class Date
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }        

        public Branch Branch { get; set; }

        public Service Service { get; set; }

        public Employee Employee { get; set; }

       


        public Customer Customer { get; set; }

        

        public DateTime AppointmentDate { get; set; }
            
        public Status Status { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModified { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        public byte[] Photo { get; set; }

        public string FromApp { get; set; }

       
    }
}
