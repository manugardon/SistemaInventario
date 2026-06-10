using SistemaInventario.Entidades.Interfaces;
using SistemaInventario.Entidades.Models;
using Microsoft.Data.SqlClient;
using SistemaInventario.AccesoDatos.Database;
using SistemaInventario.AccesoDatos.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositories
{
    public class ProductoRepository : IRepositorio<Producto>
    {
        public void Insertar(Producto entidad)
        {
            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"INSERT INTO Productos
              (
                Nombre,
                PrecioUnitario,
                CategoriaId,
                SuplidorId,
                FechaCreacion,
                Activo
              )
              VALUES
              (
                @Nombre,
                @Precio,
                @CategoriaId,
                @SuplidorId,
                GETDATE(),
                1
              )";

                SqlCommand cmd =
                    new(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@Nombre",
                    entidad.Nombre);

                cmd.Parameters.AddWithValue(
                    "@Precio",
                    entidad.PrecioUnitario);

                cmd.Parameters.AddWithValue(
                    "@CategoriaId",
                    entidad.CategoriaId);

                cmd.Parameters.AddWithValue(
                    "@SuplidorId",
                    entidad.SuplidorId);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                    ex.Message);

                throw;
            }

        }

        public void Actualizar(Producto entidad)
        {
            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"UPDATE Productos
              SET
                Nombre = @Nombre,
                PrecioUnitario = @Precio,
                CategoriaId = @CategoriaId,
                SuplidorId = @SuplidorId,
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
                    "@Precio",
                    entidad.PrecioUnitario);

                cmd.Parameters.AddWithValue(
                    "@CategoriaId",
                    entidad.CategoriaId);

                cmd.Parameters.AddWithValue(
                    "@SuplidorId",
                    entidad.SuplidorId);

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
            ///Se borra pero sigue disponible, por si aca

            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"UPDATE Productos
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

        public Producto ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos =new();

            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT *
          FROM Productos
          WHERE Activo = 1";

            SqlCommand cmd =
                new(sql, cn);

            SqlDataReader dr =
                cmd.ExecuteReader();

            while (dr.Read())
            {
                productos.Add(
                    new Producto
                    {
                        Id =
                            Convert.ToInt32(
                                dr["Id"]),

                        Nombre =
                            dr["Nombre"].ToString(),

                        PrecioUnitario =
                            Convert.ToDecimal(
                                dr["PrecioUnitario"]),

                        CategoriaId =
                            Convert.ToInt32(
                                dr["CategoriaId"]),

                        SuplidorId =
                            Convert.ToInt32(
                                dr["SuplidorId"])
                    });
            }

            return productos;
        }

        public List<Producto>
        ObtenerEliminadas()
        {
            List<Producto> productos =
                new();

            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT *
          FROM Productos
          WHERE Activo = 0";

            SqlCommand cmd =
                new(sql, cn);

            SqlDataReader dr =
                cmd.ExecuteReader();

            while (dr.Read())
            {
                productos.Add(
                    new Producto
                    {
                        Id =
                            Convert.ToInt32(
                                dr["Id"]),

                        Nombre =
                            dr["Nombre"].ToString()
                    });
            }

            return productos;
        }

        public void Restaurar(int id)
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"UPDATE Productos
          SET Activo = 1
          WHERE Id = @Id";

            SqlCommand cmd =
                new(sql, cn);

            cmd.Parameters.AddWithValue(
                "@Id",
                id);

            cmd.ExecuteNonQuery();
        }

        public int ContarActivos()
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT COUNT(*)
          FROM Productos
          WHERE Activo = 1";

            SqlCommand cmd =
                new(sql, cn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }



    }
}
