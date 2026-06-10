using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.LogicaNegocio.Validators;
using SistemaInventario.AccesoDatos.Repositories;
using SistemaInventario.Entidades.Models;

namespace SistemaInventario.LogicaNegocio.Services
{
    public class CategoriaService
    {
        private readonly CategoriaRepository
            repository;

        public CategoriaService(CategoriaRepository repository)
        {
            this.repository = repository;
        }

        public List<Categoria>
        ObtenerCategorias()
        {
            return repository
                .ObtenerTodos();
        }

        public string Guardar(Categoria categoria)
        {
            string error =
                CategoriaValidator
                .Validar(categoria);

            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            if (repository.ExisteNombre(categoria.Nombre))
            {
                return
                    "Ya existe una categoría con ese nombre.";
            }

            repository.Insertar(categoria);

            return string.Empty;
        }

        public bool ExisteNombre(string nombre)
        {
            return repository
                .ExisteNombre(nombre);
        }

        public void Actualizar(Categoria categoria)
        {
            repository.Actualizar(categoria);
        }

        public string Eliminar(int id)
        {
            if (repository.TieneProductosActivos(id))
            {
                return
                    "No se puede eliminar una categoría con productos activos.";
            }

            repository.Eliminar(id);

            return string.Empty;
        }

        public List<Categoria>
            ObtenerEliminadas()
        {
            return repository
                .ObtenerEliminadas();
        }

        public void Restaurar(int id)
        {
            repository.Restaurar(id);
        }

        public int ContarActivas()
        {
            return repository
                .ContarActivas();
        }



    }
}
