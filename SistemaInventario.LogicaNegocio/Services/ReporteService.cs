using SistemaInventario.AccesoDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio.Services
{
    public class ReporteService
    {
        /// <summary>
        /// Aquí están los LINQ, PONGO ESTO PARA ORIENTARME
        /// </summary>

        private readonly ProductoRepository
            productoRepository =
                new ProductoRepository();

        private readonly CategoriaRepository
            categoriaRepository =
                new CategoriaRepository();

        private readonly SuplidorRepository
            suplidorRepository =
                new SuplidorRepository();

        // LINQ #1
        public object ProductosPorCategoria()
        {
            var productos =
                productoRepository.ObtenerTodos();

            return productos
                .GroupBy(p => p.CategoriaId)
                .Select(g => new
                {
                    CategoriaId = g.Key,
                    Cantidad = g.Count()
                })
                .ToList();
        }

        // LINQ #2
        public object PromedioPrecioPorCategoria()
        {
            var productos =
                productoRepository.ObtenerTodos();

            return productos
                .GroupBy(p => p.CategoriaId)
                .Select(g => new
                {
                    CategoriaId = g.Key,
                    Promedio = g.Average(
                        x => x.PrecioUnitario)
                })
                .ToList();
        }

        // LINQ #3
        public object TopSuplidores()
        {
            var productos =
                productoRepository.ObtenerTodos();

            return productos
                .GroupBy(p => p.SuplidorId)
                .Select(g => new
                {
                    SuplidorId = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(
                    x => x.Cantidad)
                .Take(5)
                .ToList();
        }

        // LINQ #4
        public object BuscarProductos(
            string texto)
        {
            var productos =
                productoRepository.ObtenerTodos();

            return productos
                .Where(p =>
                    p.Nombre
                    .ToLower()
                    .Contains(
                        texto.ToLower()))
                .ToList();
        }

        // LINQ #5
        public object ProductosPorPrecio(
            decimal minimo,
            decimal maximo)
        {
            var productos =
                productoRepository.ObtenerTodos();

            return productos
                .Where(p =>
                    p.PrecioUnitario >= minimo
                    &&
                    p.PrecioUnitario <= maximo)
                .ToList();
        }

    }
}
