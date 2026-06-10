using System;
using System.Collections.Generic;
using SistemaInventario.AccesoDatos.Repositories;
using SistemaInventario.Entidades.Models;
using SistemaInventario.LogicaNegocio.Services;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario.Presentacion.Forms
{
    public partial class FrmRegistro : Form
    {

        private readonly UsuarioService
        usuarioService;

        public FrmRegistro()
        {
            InitializeComponent();
            usuarioService =
            new UsuarioService(
            new UsuarioRepository());
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario =
    new Usuario
    {
        UsuarioNombre =
            txtUsuario.Text,

        Clave =
            txtClave.Text,

        FechaCreacion =
            DateTime.Now,

        Activo = true
    };

            usuarioService
                .Registrar(usuario);

            MessageBox.Show(
                "Usuario registrado correctamente.");

            Close();
        }
    }
}
