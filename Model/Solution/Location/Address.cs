using Model.Solution.Geographic;
using Model.Solution.Location;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Solution.Location
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public City City { get; set; }

        public Location.Type AddressType { get; set; }

        public bool IsEnabled { get; set; }

    }
}
