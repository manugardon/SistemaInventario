using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Entidades.Interfaces
{
    public interface IRepositorio<T>
    {
        void Insertar(T entidad);

        void Actualizar(T entidad);

        void Eliminar(int id);

        T ObtenerPorId(int id);

        List<T> ObtenerTodos();

    }
}
