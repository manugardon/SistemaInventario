using System;
using System.Collections.Generic;
using SistemaInventario.AccesoDatos.Repositories;
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
    public partial class FrmLogin : Form
    {

        private readonly UsuarioService
        usuarioService;

        public FrmLogin()
        {
            InitializeComponent();

            usuarioService =
            new UsuarioService(
            new UsuarioRepository());

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var usuario =
            usuarioService.Login(
            txtUsuario.Text,
            txtClave.Text);

            if (usuario != null)
            {
                FrmMenuPrincipal menu =
                    new FrmMenuPrincipal();

                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
