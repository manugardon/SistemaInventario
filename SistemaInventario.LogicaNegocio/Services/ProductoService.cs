using SistemaInventario.AccesoDatos.Repositories;
using SistemaInventario.Entidades.Models;
using SistemaInventario.LogicaNegocio.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio.Services
{
    public class ProductoService
    {

        private readonly ProductoRepository
            repository;

        public ProductoService(
            ProductoRepository repository)
        {
            this.repository = repository;
        }

        public List<Producto>
    ObtenerProductos()
        {
            return repository
                .ObtenerTodos();
        }

        public string Guardar(Producto producto)
        {
            string error =
                ProductoValidator
                .Validar(producto);

            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            repository.Insertar(
                producto);

            return string.Empty;
        }

        public void Actualizar(Producto producto)
        {
            repository.Actualizar(
                producto);
        }

        public void Eliminar(int id)
        {
            repository.Eliminar(id);
        }

        public List<Producto>
        ObtenerEliminadas()
        {
            return repository
                .ObtenerEliminadas();
        }

        public void Restaurar(int id)
        {
            repository.Restaurar(id);
        }

        public int ContarActivos()
        {
            return repository
                .ContarActivos();
        }



    }
}
