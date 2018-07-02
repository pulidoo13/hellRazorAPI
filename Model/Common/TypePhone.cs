using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.Common
{
    public enum TypePhone
    {
        [Description("Not Assigned")]
        NotAssigned = 0,
        [Description("Principal")]
        Principal = 1,
        [Description("CellPhone")]
        CellPhone = 2,
        [Description("Home")]
        Home = 3,
    }
}
