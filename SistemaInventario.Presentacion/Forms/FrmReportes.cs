using System;
using System.Collections.Generic;
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
    public partial class FrmReportes : Form
    {
        private readonly ReporteService
            reporteService =
        new ReporteService();

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            switch (
       cmbReportes.SelectedIndex)
            {
                case 0:

                    dgvReportes.DataSource =
                        reporteService
                        .PromedioPrecioPorCategoria();

                    break;

                case 1:

                    dgvReportes.DataSource =
                        reporteService
                        .ProductosPorCategoria();

                    break;

                case 2:

                    dgvReportes.DataSource =
                        reporteService
                        .TopSuplidores();

                    break;

                case 3:

                    dgvReportes.DataSource =
                   reporteService
                   .ProductosPorPrecio(
                       Convert.ToDecimal(
                           txtPrecioMinimo.Text),
                       Convert.ToDecimal(
                           txtPrecioMaximo.Text));

                    break;

                case 4:

                    dgvReportes.DataSource =
                        reporteService
                        .BuscarProductos(
                            txtBusqueda.Text);

                    break;
            }
        }
    }
}
