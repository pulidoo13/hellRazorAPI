using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.Solution.Location
{
   public  enum Type
    {
       [Description("Not Assigned")]
        NotAssigned = 0,
        [Description("Principal")]
        Principal = 1,
        [Description("Tax Fiscal")]
        TaxFiscal = 2,
       
    } 
    
}
