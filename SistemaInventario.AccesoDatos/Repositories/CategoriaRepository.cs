using Microsoft.Data.SqlClient;
using SistemaInventario.AccesoDatos.Database;
using SistemaInventario.AccesoDatos.Logger;
using SistemaInventario.Entidades.Interfaces;
using SistemaInventario.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositories
{
    public class CategoriaRepository : IRepositorio<Categoria>
    {
        public void Insertar(Categoria entidad)
        {

            try
            {

                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"INSERT INTO Categorias
                      (
                        Nombre,
                        Descripcion,
                        FechaCreacion,
                        Activo
                      )
                      VALUES
                      (
                        @Nombre,
                        @Descripcion,
                        GETDATE(),
                        1
                      )";

                SqlCommand cmd =
                    new(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@Nombre",
                    entidad.Nombre);

                cmd.Parameters.AddWithValue(
                    "@Descripcion",
                    entidad.Descripcion);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                    ex.Message);

                throw;
            }

        }

        public void Actualizar(Categoria entidad)
        {
            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"UPDATE Categorias
          SET
            Nombre = @Nombre,
            Descripcion = @Descripcion,
            FechaModificacion = GETDATE()
          WHERE Id = @Id";

                SqlCommand cmd =
                    new(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@Id",
                    entidad.Id);

                cmd.Parameters.AddWithValue(
                    "@Nombre",
                    entidad.Nombre);

                cmd.Parameters.AddWithValue(
                    "@Descripcion",
                    entidad.Descripcion);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                    ex.Message);
            }

        }

        public void Eliminar(int id)
        {
            /// No se borra del todo, pa la papelera

            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"UPDATE Categorias
              SET Activo = 0,
                  FechaModificacion = GETDATE()
              WHERE Id = @Id";

                SqlCommand cmd =
                    new(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@Id",
                    id);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                    ex.Message);
            }

        }

        public Categoria ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObtenerTodos()
        {
            List<Categoria> categorias =
            new();

            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"SELECT *
          FROM Categorias
          WHERE Activo = 1";

                SqlCommand cmd =
                    new(sql, cn);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    categorias.Add(
                        new Categoria
                        {
                            Id = Convert.ToInt32(
                                dr["Id"]),

                            Nombre =
                                dr["Nombre"]
                                .ToString(),

                            Descripcion =
                                dr["Descripcion"]
                                .ToString(),

                            Activo =
                                Convert.ToBoolean(
                                    dr["Activo"])
                        });
                }
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                ex.Message);
            }

            return categorias;
        }

        public bool ExisteNombre(string nombre)
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT COUNT(*)
          FROM Categorias
          WHERE Nombre = @Nombre
          AND Activo = 1";

            SqlCommand cmd =
                new(sql, cn);

            cmd.Parameters.AddWithValue(
                "@Nombre",
                nombre);

            int cantidad =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            return cantidad > 0;
        }

        public List<Categoria>
        ObtenerEliminadas()
        {
            List<Categoria> categorias =
                new();

            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT *
          FROM Categorias
          WHERE Activo = 0";

            SqlCommand cmd =
                new(sql, cn);

            SqlDataReader dr =
                cmd.ExecuteReader();

            while (dr.Read())
            {
                categorias.Add(
                    new Categoria
                    {
                        Id =
                            Convert.ToInt32(
                                dr["Id"]),

                        Nombre =
                            dr["Nombre"]
                            .ToString(),

                        Descripcion =
                            dr["Descripcion"]
                            .ToString()
                    });
            }

            return categorias;
        }

        public void Restaurar(int id)
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"UPDATE Categorias
          SET Activo = 1
          WHERE Id = @Id";

            SqlCommand cmd =
                new(sql, cn);

            cmd.Parameters.AddWithValue(
                "@Id",
                id);

            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// Si tiene productos arriba, no podemos desaparecerla así por así
        /// </summary>
        /// <param name="categoriaId"></param>
        /// <returns></returns>

        public bool TieneProductosActivos(int categoriaId)
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT COUNT(*)
          FROM Productos
          WHERE CategoriaId = @CategoriaId
          AND Activo = 1";

            SqlCommand cmd = new(sql, cn);

            cmd.Parameters.AddWithValue(
                "@CategoriaId",
                categoriaId);

            int cantidad =
                Convert.ToInt32(cmd.ExecuteScalar());

            return cantidad > 0;
        }

        public int ContarActivas()
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT COUNT(*)
          FROM Categorias
          WHERE Activo = 1";

            SqlCommand cmd =
                new(sql, cn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }



    }
}
