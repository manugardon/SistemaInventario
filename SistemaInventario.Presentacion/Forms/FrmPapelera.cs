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
    public partial class FrmPapelera : Form
    {
        private int idSeleccionado = 0;

        private readonly CategoriaService
            categoriaService;

        private readonly SuplidorService
            suplidorService;

        private readonly ProductoService
            productoService;

        public FrmPapelera()
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
        }

        private void CargarPapelera()
        {
            switch (
                cmbTipo.Text)
            {
                case "Categorías":

                    dgvPapelera.DataSource =
                        categoriaService
                        .ObtenerEliminadas();

                    break;

                case "Suplidores":

                    dgvPapelera.DataSource =
                        suplidorService
                        .ObtenerEliminadas();

                    break;

                case "Productos":

                    dgvPapelera.DataSource =
                        productoService
                        .ObtenerEliminadas();

                    break;
            }
        }


        private void FrmPapelera_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarPapelera();

        }

        private void dgvPapelera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            idSeleccionado =
                Convert.ToInt32(
                    dgvPapelera.Rows[e.RowIndex]
                    .Cells["Id"].Value);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un registro.");

                return;
            }

            switch (
                cmbTipo.Text)
            {
                case "Categorías":

                    categoriaService
                        .Restaurar(
                            idSeleccionado);

                    break;

                case "Suplidores":

                    suplidorService
                        .Restaurar(
                            idSeleccionado);

                    break;

                case "Productos":

                    productoService
                        .Restaurar(
                            idSeleccionado);

                    break;
            }

            MessageBox.Show(
                "Registro restaurado.");

            CargarPapelera();

            idSeleccionado = 0;

        }
    }
}
