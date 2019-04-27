using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.COMON.Entidades
{
    public class Vale:Base
    {
        
        public DateTime FechaHora { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public List<Material> MaterialesPrestados { get; set; }
        public Empleado solicitante { get; set; }
        public Empleado EncargadoAlmacen { get; set; }


    }
}
