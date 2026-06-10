using SistemaInventario.AccesoDatos.Repositories;
using SistemaInventario.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio.Services
{
    public class UsuarioService
    {

        private readonly
            UsuarioRepository
            repository;

        public UsuarioService(
            UsuarioRepository repository)
        {
            this.repository =
                repository;
        }

        public Usuario Login(
            string usuario,
            string clave)
        {
            return repository
                .Login(
                    usuario,
                    clave);
        }

        public void Registrar(
            Usuario usuario)
        {
            repository
                .Registrar(
                    usuario);
        }

    }
}
