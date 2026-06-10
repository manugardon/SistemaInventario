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
    public class SuplidorService
    {
        private readonly SuplidorRepository
            repository;

        public SuplidorService(
            SuplidorRepository repository)
        {
            this.repository = repository;
        }
        public List<Suplidor>
            ObtenerSuplidores()
        {
            return repository
                .ObtenerTodos();
        }

        public string Guardar(
            Suplidor suplidor)
        {
            string error =
                SuplidorValidator
                .Validar(suplidor);

            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            if (repository.ExisteEmpresa(
                suplidor.NombreEmpresa))
            {
                return
                    "Ya existe esa empresa.";
            }

            repository.Insertar(
                suplidor);

            return string.Empty;
        }

        public void Actualizar(Suplidor suplidor)
        {
            repository.Actualizar(
                suplidor);
        }

        public void Eliminar(int id)
        {
            repository.Eliminar(id);
        }

        public List<Suplidor>
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
