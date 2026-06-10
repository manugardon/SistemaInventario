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
    public class SuplidorRepository : IRepositorio<Suplidor>
    {
        public void Insertar(Suplidor entidad)
        {
            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"INSERT INTO Suplidores
              (
                NombreEmpresa,
                NombreContacto,
                Telefono,
                Correo,
                SitioWeb,
                FechaCreacion,
                Activo
              )
              VALUES
              (
                @NombreEmpresa,
                @NombreContacto,
                @Telefono,
                @Correo,
                @SitioWeb,
                GETDATE(),
                1
              )";

                SqlCommand cmd =
                    new(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@NombreEmpresa",
                    entidad.NombreEmpresa);

                cmd.Parameters.AddWithValue(
                    "@NombreContacto",
                    entidad.NombreContacto);

                cmd.Parameters.AddWithValue(
                    "@Telefono",
                    entidad.Telefono);

                cmd.Parameters.AddWithValue(
                    "@Correo",
                    entidad.Correo);

                cmd.Parameters.AddWithValue(
                    "@SitioWeb",
                    entidad.SitioWeb ?? "");

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                    ex.Message);

                throw;
            }
        }

        public void Actualizar(Suplidor entidad)
        {
            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"UPDATE Suplidores
              SET
                NombreEmpresa = @NombreEmpresa,
                NombreContacto = @NombreContacto,
                Telefono = @Telefono,
                Correo = @Correo,
                SitioWeb = @SitioWeb,
                FechaModificacion = GETDATE()
              WHERE Id = @Id";

                SqlCommand cmd =
                    new(sql, cn);

                cmd.Parameters.AddWithValue(
                    "@Id",
                    entidad.Id);

                cmd.Parameters.AddWithValue(
                    "@NombreEmpresa",
                    entidad.NombreEmpresa);

                cmd.Parameters.AddWithValue(
                    "@NombreContacto",
                    entidad.NombreContacto);

                cmd.Parameters.AddWithValue(
                    "@Telefono",
                    entidad.Telefono);

                cmd.Parameters.AddWithValue(
                    "@Correo",
                    entidad.Correo);

                cmd.Parameters.AddWithValue(
                    "@SitioWeb",
                    entidad.SitioWeb ?? "");

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
            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"UPDATE Suplidores
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

        public Suplidor ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Suplidor> ObtenerTodos()
        {
            List<Suplidor> suplidores =new();

            try
            {
                using SqlConnection cn =
                    Conexion.Instancia
                    .ObtenerConexion();

                cn.Open();

                string sql =
                    @"SELECT *
              FROM Suplidores
              WHERE Activo = 1";

                SqlCommand cmd =
                    new(sql, cn);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    suplidores.Add(
                        new Suplidor
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            NombreEmpresa = dr["NombreEmpresa"].ToString(),
                            NombreContacto = dr["NombreContacto"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            SitioWeb = dr["SitioWeb"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                }
            }
            catch (SqlException ex)
            {
                LoggerSistema.Registrar(
                    ex.Message);
            }

            return suplidores;

        }

        public bool ExisteEmpresa(string empresa)
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT COUNT(*)
          FROM Suplidores
          WHERE NombreEmpresa = @Empresa
          AND Activo = 1";

            SqlCommand cmd =
                new(sql, cn);

            cmd.Parameters.AddWithValue(
                "@Empresa",
                empresa);

            int cantidad =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            return cantidad > 0;
        }

        public List<Suplidor>
    ObtenerEliminadas()
        {
            List<Suplidor> suplidores =
                new();

            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"SELECT *
          FROM Suplidores
          WHERE Activo = 0";

            SqlCommand cmd =
                new(sql, cn);

            SqlDataReader dr =
                cmd.ExecuteReader();

            while (dr.Read())
            {
                suplidores.Add(
                    new Suplidor
                    {
                        Id =
                            Convert.ToInt32(
                                dr["Id"]),

                        NombreEmpresa =
                            dr["NombreEmpresa"].ToString()
                    });
            }

            return suplidores;
        }

        public void Restaurar(int id)
        {
            using SqlConnection cn =
                Conexion.Instancia
                .ObtenerConexion();

            cn.Open();

            string sql =
                @"UPDATE Suplidores
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
          FROM Suplidores
          WHERE Activo = 1";

            SqlCommand cmd =
                new(sql, cn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }
    }
}

