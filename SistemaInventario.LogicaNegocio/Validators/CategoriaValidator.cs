using SistemaInventario.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio.Validators
{
    public static class CategoriaValidator
    {
        public static string Validar(
            Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(
                categoria.Nombre))
            {
                return
                    "Nombre obligatorio.";
            }

            if (categoria.Nombre.Length
                < 3)
            {
                return
                    "Mínimo 3 caracteres.";
            }

            if (categoria.Nombre.Length
                > 100)
            {
                return
                    "Máximo 100 caracteres.";
            }

            if (string.IsNullOrWhiteSpace(
                categoria.Descripcion))
            {
                return
                    "Descripción obligatoria.";
            }

            if (categoria.Descripcion.Length
                > 500)
            {
                return
                    "Máximo 500 caracteres.";
            }

            return string.Empty;

        }
    }
}
