using Inventario.COMON.Entidades;
using Inventario.COMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        public List<Empleado> Leer => throw new NotImplementedException();

        public bool Crear(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Empleado entidadOriginal, Empleado entidadModificada)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(string Id, Empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
