using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Logger
{
    /// <summary>
    /// Si algo explota, por lo menos queda guardao aquí
    /// </summary>
    public static class LoggerSistema
    {
        private static readonly string ruta =
           "errores.log";

        public static void Registrar(
            string mensaje)
        {
            File.AppendAllText(
                ruta,
                $"{DateTime.Now} - {mensaje}" +
                Environment.NewLine);
        }

    }
}
