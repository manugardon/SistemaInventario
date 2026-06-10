using SistemaInventario.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio.Validators
{
    public static class ProductoValidator
    {
        public static string Validar(
            Producto producto)
        {
            if (string.IsNullOrWhiteSpace(
                producto.Nombre))
            {
                return
                    "Nombre obligatorio.";
            }

            if (producto.PrecioUnitario <= 0)
            {
                return
                    "El precio debe ser mayor que cero.";
            }

            if (producto.CategoriaId <= 0)
            {
                return
                    "Seleccione una categoría.";
            }

            if (producto.SuplidorId <= 0)
            {
                return
                    "Seleccione un suplidor.";
            }

            return string.Empty;
        }
    }
}
