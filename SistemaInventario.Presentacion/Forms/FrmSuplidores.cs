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
    public partial class FrmSuplidores : Form
    {
        private readonly SuplidorService
        suplidorService;

        private int suplidorSeleccionado = 0;

        public FrmSuplidores()
        {
            InitializeComponent();

            suplidorService = new SuplidorService(
            new SuplidorRepository());

            CargarSuplidores();

        }
        private void CargarSuplidores()
        {
            dgvSuplidores.DataSource = suplidorService.ObtenerSuplidores();
        }
        private void LimpiarFormulario()
        {
            txtEmpresa.Clear();
            txtContacto.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtSitioWeb.Clear();
            suplidorSeleccionado = 0;
        }


        private void FrmSuplidores_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Suplidor suplidor =
        new Suplidor
        {
            NombreEmpresa =
                txtEmpresa.Text,

            NombreContacto =
                txtContacto.Text,

            Telefono =
                txtTelefono.Text,

            Correo =
                txtCorreo.Text,

            SitioWeb =
                txtSitioWeb.Text
        };

            string resultado =
                suplidorService
                .Guardar(suplidor);

            if (!string.IsNullOrEmpty(
                resultado))
            {
                MessageBox.Show(
                    resultado);

                return;
            }

            MessageBox.Show(
                "Suplidor guardado.");

            CargarSuplidores();

            LimpiarFormulario();
        }

        private void dgvSuplidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            suplidorSeleccionado =
                Convert.ToInt32(
                    dgvSuplidores.Rows[e.RowIndex]
                    .Cells["Id"].Value);

            txtEmpresa.Text =
                dgvSuplidores.Rows[e.RowIndex]
                .Cells["NombreEmpresa"]
                .Value
                .ToString();

            txtContacto.Text =
                dgvSuplidores.Rows[e.RowIndex]
                .Cells["NombreContacto"]
                .Value
                .ToString();

            txtTelefono.Text =
                dgvSuplidores.Rows[e.RowIndex]
                .Cells["Telefono"]
                .Value
                .ToString();

            txtCorreo.Text =
                dgvSuplidores.Rows[e.RowIndex]
                .Cells["Correo"]
                .Value
                .ToString();

            txtSitioWeb.Text =
                dgvSuplidores.Rows[e.RowIndex]
                .Cells["SitioWeb"]
                .Value
                .ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (suplidorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un suplidor.");

                return;
            }

            Suplidor suplidor =
                new Suplidor
                {
                    Id =
                        suplidorSeleccionado,

                    NombreEmpresa =
                        txtEmpresa.Text,

                    NombreContacto =
                        txtContacto.Text,

                    Telefono =
                        txtTelefono.Text,

                    Correo =
                        txtCorreo.Text,

                    SitioWeb =
                        txtSitioWeb.Text
                };

            suplidorService.Actualizar(
                suplidor);

            MessageBox.Show(
                "Suplidor actualizado.");

            CargarSuplidores();

            LimpiarFormulario();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (suplidorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un suplidor.");

                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Eliminar suplidor?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (respuesta ==
                DialogResult.Yes)
            {
                suplidorService.Eliminar(
                    suplidorSeleccionado);

                MessageBox.Show(
                    "Suplidor enviado a la papelera.");

                CargarSuplidores();

                LimpiarFormulario();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
           
        }
    }
}
