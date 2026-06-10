namespace SistemaInventario.Presentacion.Forms
{
    partial class FrmSuplidores
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmpresa = new TextBox();
            txtContacto = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtSitioWeb = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            dgvSuplidores = new DataGridView();
            btnProductos = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuplidores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "Contacto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 302);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 375);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 4;
            label5.Text = "Sitio web:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(131, 75);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(150, 31);
            txtEmpresa.TabIndex = 5;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(131, 152);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(150, 31);
            txtContacto.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(131, 220);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(131, 302);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 31);
            txtCorreo.TabIndex = 8;
            // 
            // txtSitioWeb
            // 
            txtSitioWeb.Location = new Point(131, 375);
            txtSitioWeb.Name = "txtSitioWeb";
            txtSitioWeb.Size = new Size(150, 31);
            txtSitioWeb.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(350, 419);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(525, 419);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(695, 419);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(848, 419);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvSuplidores
            // 
            dgvSuplidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuplidores.Location = new Point(350, 75);
            dgvSuplidores.Name = "dgvSuplidores";
            dgvSuplidores.RowHeadersWidth = 62;
            dgvSuplidores.Size = new Size(610, 325);
            dgvSuplidores.TabIndex = 14;
            dgvSuplidores.CellClick += dgvSuplidores_CellClick;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(12, 455);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(112, 34);
            btnProductos.TabIndex = 15;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(424, 18);
            label6.Name = "label6";
            label6.Size = new Size(155, 29);
            label6.TabIndex = 16;
            label6.Text = "SUPLIDORES";
            // 
            // FrmSuplidores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(981, 511);
            Controls.Add(label6);
            Controls.Add(btnProductos);
            Controls.Add(dgvSuplidores);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtSitioWeb);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtContacto);
            Controls.Add(txtEmpresa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSuplidores";
            Text = "FrmSuplidores";
            Load += FrmSuplidores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuplidores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmpresa;
        private TextBox txtContacto;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtSitioWeb;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dgvSuplidores;
        private Button btnProductos;
        private Label label6;
    }
}