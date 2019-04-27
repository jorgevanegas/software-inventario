using Inventario.COMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.COMON.Interfaces
{
    public interface IRepositorio<T> where T:Base
    {
        bool Crear(T entidad);
        bool Editar(T entidad);
        bool Eliminar(string Id, T entidadModificada );
        List<T> Leer { get; }
    }
}
