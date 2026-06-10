using SistemaInventario.AccesoDatos.Repositories;
using SistemaInventario.Entidades.Models;
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
    public partial class FrmProductos : Form
    {
        private readonly ProductoService
            productoService;

        private readonly CategoriaService
            categoriaService;

        private readonly SuplidorService
            suplidorService;

        private int productoSeleccionado = 0;

        public FrmProductos()
        {
            InitializeComponent();

            productoService =
        new ProductoService(
            new ProductoRepository());

            categoriaService =
                new CategoriaService(
                    new CategoriaRepository());

            suplidorService =
                new SuplidorService(
                    new SuplidorRepository());

            CargarCategorias();

            CargarSuplidores();

            CargarProductos();
        }

        private void CargarCategorias()
        {
            cmbCategoria.DataSource =
                categoriaService
                .ObtenerCategorias();

            cmbCategoria.DisplayMember =
                "Nombre";

            cmbCategoria.ValueMember =
                "Id";

            cmbCategoria.SelectedIndex = -1;
        }
        private void CargarSuplidores()
        {
            cmbSuplidor.DataSource = null;

            cmbSuplidor.DataSource =
                suplidorService
                .ObtenerSuplidores();

            cmbSuplidor.DisplayMember =
                "NombreEmpresa";

            cmbSuplidor.ValueMember =
                "Id";

            cmbSuplidor.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource =
                productoService
                .ObtenerProductos();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();

            txtPrecio.Clear();

            cmbCategoria.SelectedIndex = -1;

            cmbSuplidor.SelectedIndex = -1;

            productoSeleccionado = 0;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto =
    new Producto
    {
        Nombre =
            txtNombre.Text,

        PrecioUnitario =
            Convert.ToDecimal(
                txtPrecio.Text),

        CategoriaId =
            Convert.ToInt32(
                cmbCategoria.SelectedValue),

        SuplidorId =
            Convert.ToInt32(
                cmbSuplidor.SelectedValue)
    };

            string resultado =
                productoService
                .Guardar(producto);

            if (!string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show(resultado);

                return;
            }

            MessageBox.Show(
                "Producto guardado correctamente.");

            CargarProductos();

            LimpiarFormulario();

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            productoSeleccionado =
                Convert.ToInt32(
                    dgvProductos.Rows[e.RowIndex]
                    .Cells["Id"].Value);

            txtNombre.Text =
                dgvProductos.Rows[e.RowIndex]
                .Cells["Nombre"]
                .Value
                .ToString();

            txtPrecio.Text =
                dgvProductos.Rows[e.RowIndex]
                .Cells["PrecioUnitario"]
                .Value
                .ToString();

            cmbCategoria.SelectedValue =
                dgvProductos.Rows[e.RowIndex]
                .Cells["CategoriaId"]
                .Value;

            cmbSuplidor.SelectedValue =
                dgvProductos.Rows[e.RowIndex]
                .Cells["SuplidorId"]
                .Value;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto.");

                return;
            }

            Producto producto =
                new Producto
                {
                    Id =
                        productoSeleccionado,

                    Nombre =
                        txtNombre.Text,

                    PrecioUnitario =
                        Convert.ToDecimal(
                            txtPrecio.Text),

                    CategoriaId =
                        Convert.ToInt32(
                            cmbCategoria.SelectedValue),

                    SuplidorId =
                        Convert.ToInt32(
                            cmbSuplidor.SelectedValue)
                };

            productoService.Actualizar(
                producto);

            MessageBox.Show(
                "Producto actualizado.");

            CargarProductos();

            LimpiarFormulario();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto.");

                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Eliminar producto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (respuesta ==
                DialogResult.Yes)
            {
                productoService.Eliminar(
                    productoSeleccionado);

                MessageBox.Show(
                    "Producto enviado a la papelera.");

                CargarProductos();

                LimpiarFormulario();
            }

        }
    }
}
