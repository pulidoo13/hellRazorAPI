using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.Dates
{
    public enum Status
    {
       
        [Description("Sin Asignar")]
        NotAssigned = 0,
        [Description("Activa")]
        Active = 1,
        [Description("Cancelada")]
        Cancel = 2,
        [Description("Vencida")]
        Due = 3,
        [Description("Pendiente")]
        Pending = 4,
    }
}
