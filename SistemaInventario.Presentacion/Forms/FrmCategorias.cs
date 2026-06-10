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
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaService
        categoriaService;

        private int categoriaSeleccionada = 0;

        private List<string> fotos =
            new List<string>();


        public FrmCategorias()
        {
            InitializeComponent();
            categoriaService =
            new CategoriaService(
            new CategoriaRepository());

            CargarCategorias();
        }
        private void CargarCategorias()
        {
            dgvCategorias.DataSource =
            categoriaService
            .ObtenerCategorias();

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();

            rtbDescripcion.Clear();

            lstFotos.Items.Clear();

            fotos.Clear();

            categoriaSeleccionada = 0;
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            if (fotos.Count >= 5)
            {
                MessageBox.Show(
                    "Máximo 5 fotos.");

                return;
            }

            OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Filter =
                "Imágenes|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog()
                == DialogResult.OK)
            {
                FileInfo archivo =
                    new FileInfo(
                        dialog.FileName);

                if (archivo.Length >
                    2 * 1024 * 1024)
                {
                    MessageBox.Show(
                        "La foto supera los 2 MB.");

                    return;
                }

                fotos.Add(
                    dialog.FileName);

                lstFotos.Items.Add(
                    Path.GetFileName(
                        dialog.FileName));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria =
                    new Categoria
                    {
                        Nombre =
                            txtNombre.Text,

                        Descripcion =
                            rtbDescripcion.Text
                    };

                string resultado =
                    categoriaService
                    .Guardar(categoria);

                if (!string.IsNullOrEmpty(
                    resultado))
                {
                    MessageBox.Show(
                        resultado);

                    return;
                }

                MessageBox.Show(
                    "Categoría guardada.");

                LimpiarFormulario();

                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            categoriaSeleccionada =
                Convert.ToInt32(
                    dgvCategorias.Rows[e.RowIndex]
                    .Cells["Id"].Value);

            txtNombre.Text =
                dgvCategorias.Rows[e.RowIndex]
                .Cells["Nombre"]
                .Value
                .ToString();

            rtbDescripcion.Text =
                dgvCategorias.Rows[e.RowIndex]
                .Cells["Descripcion"]
                .Value
                .ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una categoría.");

                return;
            }

            Categoria categoria =
                new Categoria
                {
                    Id =
                        categoriaSeleccionada,

                    Nombre =
                        txtNombre.Text,

                    Descripcion =
                        rtbDescripcion.Text
                };

            categoriaService.Actualizar(
                categoria);

            MessageBox.Show(
                "Categoría actualizada.");

            CargarCategorias();

            LimpiarFormulario();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (categoriaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una categoría.");

                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea eliminar la categoría?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (respuesta ==
                DialogResult.Yes)
            {
                string resultado = categoriaService.Eliminar(categoriaSeleccionada);

                if (!string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show(resultado);

                    return;
                }

                MessageBox.Show("Categoría enviada a la papelera.");

                CargarCategorias();

                LimpiarFormulario();
            }
        }

        private void btnSuplidores_Click(object sender, EventArgs e)
        {
            
        }
    }
}
