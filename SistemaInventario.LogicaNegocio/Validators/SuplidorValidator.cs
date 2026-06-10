using SistemaInventario.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio.Validators
{
    public static class SuplidorValidator
    {
        public static string Validar(
            Suplidor suplidor)
        {
            if (string.IsNullOrWhiteSpace(
                suplidor.NombreEmpresa))
            {
                return
                    "Empresa obligatoria.";
            }

            if (string.IsNullOrWhiteSpace(
                suplidor.NombreContacto))
            {
                return
                    "Contacto obligatorio.";
            }

            if (!Regex.IsMatch(
                suplidor.Telefono,
                @"^(809|829|849)-\d{3}-\d{4}$"))
            {
                return
                    "Teléfono inválido.";
            }

            if (!Regex.IsMatch(
                suplidor.Correo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return
                    "Correo inválido.";
            }

            if (!string.IsNullOrWhiteSpace(
                suplidor.SitioWeb))
            {
                if (!Uri.IsWellFormedUriString(
                    suplidor.SitioWeb,
                    UriKind.Absolute))
                {
                    return
                        "URL inválida.";
                }
            }

            return string.Empty;
        }

    }
}
