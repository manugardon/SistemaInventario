using SistemaInventario.AccesoDatos.Repositories;
using SistemaInventario.LogicaNegocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario.Presentacion.Forms
{
    public partial class FrmMenuPrincipal : Form
    {

        private readonly CategoriaService
            categoriaService;

        private readonly SuplidorService
            suplidorService;

        private readonly ProductoService
            productoService;

        public FrmMenuPrincipal()
        {
            InitializeComponent();

            categoriaService =
       new CategoriaService(
           new CategoriaRepository());

            suplidorService =
                new SuplidorService(
                    new SuplidorRepository());

            productoService =
                new ProductoService(
                    new ProductoRepository());

            CargarDashboard();
        }

        private void CargarDashboard()
        {
            lblCategorias.Text =
                $"Categorías: {categoriaService.ContarActivas()}";

            lblSuplidores.Text =
                $"Suplidores: {suplidorService.ContarActivos()}";

            lblProductos.Text =
                $"Productos: {productoService.ContarActivos()}";
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog();
        }

        private void btnSuplidores_Click(object sender, EventArgs e)
        {
            FrmSuplidores frmSuplidores = new FrmSuplidores();
            frmSuplidores.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            FrmPapelera frmPapelera = new FrmPapelera();
            frmPapelera.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
       MessageBox.Show(
           "¿Desea cerrar sesión?",
           "Confirmar",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (respuesta ==
                DialogResult.Yes)
            {
                FrmLogin login =
                    new FrmLogin();

                login.Show();

                this.Hide();
            }
        }
    }
}
