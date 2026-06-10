using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaInventario.AccesoDatos.Database
{
    public sealed class Conexion
    {
        /// <summary>
        /// Una sola conexion pa' que esto no se vuelva un tollo
        /// </summary>
        private static Conexion instancia;

        private readonly string cadena =
            "Data Source=Emmanuel;Initial Catalog=SistemaInventarioDB;User ID=sa;Password=123456789;TrustServerCertificate=True";

        private Conexion()
        {
        }
        /// <summary>
        /// hola mundo
        /// </summary>

        public static Conexion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Conexion();
                }

                return instancia;
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
