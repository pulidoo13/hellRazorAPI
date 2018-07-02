using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.Comercial.Products
{
   
    public enum Type
    {
        [Description("Not Assigned")]
        NotAssigned = 0,
        [Description("Cleanner")]
        Cleanner = 1,
        [Description("Manicure")]
        Manicure = 2,
        [Description("Pedicure")]
        Pedicure = 3,
        [Description("Barber")]
        Barber = 4,
    }
}
