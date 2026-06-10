namespace SistemaInventario.Presentacion.Forms
{
    partial class FrmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            rtbDescripcion = new RichTextBox();
            lstFotos = new ListBox();
            btnAgregarFoto = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            label3 = new Label();
            dgvCategorias = new DataGridView();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnSuplidores = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(136, 178);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(255, 58);
            rtbDescripcion.TabIndex = 3;
            rtbDescripcion.Text = "";
            // 
            // lstFotos
            // 
            lstFotos.FormattingEnabled = true;
            lstFotos.ItemHeight = 25;
            lstFotos.Location = new Point(136, 290);
            lstFotos.Name = "lstFotos";
            lstFotos.Size = new Size(262, 129);
            lstFotos.TabIndex = 4;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Location = new Point(169, 467);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(165, 34);
            btnAgregarFoto.TabIndex = 5;
            btnAgregarFoto.Text = "Agregar Foto";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(449, 467);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(645, 467);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(831, 467);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(996, 467);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 10;
            label3.Text = "Agregar Foto";
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(424, 112);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.Size = new Size(684, 307);
            dgvCategorias.TabIndex = 11;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 19);
            label4.Name = "label4";
            label4.Size = new Size(155, 29);
            label4.TabIndex = 12;
            label4.Text = "CATEGORIAS";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSuplidores
            // 
            btnSuplidores.Location = new Point(996, 52);
            btnSuplidores.Name = "btnSuplidores";
            btnSuplidores.Size = new Size(112, 34);
            btnSuplidores.TabIndex = 13;
            btnSuplidores.Text = "Suplidores";
            btnSuplidores.UseVisualStyleBackColor = true;
            btnSuplidores.Click += btnSuplidores_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1120, 531);
            Controls.Add(btnSuplidores);
            Controls.Add(label4);
            Controls.Add(dgvCategorias);
            Controls.Add(label3);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregarFoto);
            Controls.Add(lstFotos);
            Controls.Add(rtbDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private RichTextBox rtbDescripcion;
        private ListBox lstFotos;
        private Button btnAgregarFoto;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Label label3;
        private DataGridView dgvCategorias;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Button btnSuplidores;
    }
}