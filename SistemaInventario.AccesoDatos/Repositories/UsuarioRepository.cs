using Microsoft.Data.SqlClient;
using SistemaInventario.AccesoDatos.Database;
using SistemaInventario.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositories
{
    public class UsuarioRepository
    {

        public Usuario Login(
           string usuario,
           string clave)
        {
            using SqlConnection conexion =
            Conexion
            .Instancia
            .ObtenerConexion();

            conexion.Open();

            string sql =
                @"SELECT *
                  FROM Usuarios
                  WHERE Usuario = @Usuario
                  AND Clave = @Clave
                  AND Activo = 1";

            SqlCommand cmd =
                new SqlCommand(
                    sql,
                    conexion);

            cmd.Parameters.AddWithValue(
                "@Usuario",
                usuario);

            cmd.Parameters.AddWithValue(
                "@Clave",
                clave);

            SqlDataReader reader =
                cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Usuario
                {
                    Id =
                        Convert.ToInt32(
                            reader["Id"]),

                    UsuarioNombre =
                        reader["Usuario"]
                        .ToString()
                };
            }

            return null;
        }

        public void Registrar(
            Usuario usuario)
        {
            using SqlConnection conexion =
                Conexion
                .Instancia
                .ObtenerConexion();

            conexion.Open();

            string sql =
                @"INSERT INTO Usuarios
                (
                    Usuario,
                    Clave,
                    FechaCreacion,
                    Activo
                )
                VALUES
                (
                    @Usuario,
                    @Clave,
                    GETDATE(),
                    1
                )";

            SqlCommand cmd =
                new SqlCommand(
                    sql,
                    conexion);

            cmd.Parameters.AddWithValue(
                "@Usuario",
                usuario.UsuarioNombre);

            cmd.Parameters.AddWithValue(
                "@Clave",
                usuario.Clave);

            cmd.ExecuteNonQuery();
        }

    }
}
