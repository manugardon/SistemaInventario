namespace SistemaInventario.Presentacion.Forms
{
    partial class FrmMenuPrincipal
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
            lblTitulo = new Label();
            btnCategorias = new Button();
            btnSuplidores = new Button();
            btnProductos = new Button();
            btnPapelera = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            panelDashboard = new Panel();
            lblProductos = new Label();
            lblSuplidores = new Label();
            lblCategorias = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(209, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(302, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema Inventario";
            // 
            // btnCategorias
            // 
            btnCategorias.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorias.Location = new Point(44, 109);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(196, 46);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnSuplidores
            // 
            btnSuplidores.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuplidores.Location = new Point(44, 185);
            btnSuplidores.Name = "btnSuplidores";
            btnSuplidores.Size = new Size(196, 46);
            btnSuplidores.TabIndex = 2;
            btnSuplidores.Text = "Suplidores";
            btnSuplidores.UseVisualStyleBackColor = true;
            btnSuplidores.Click += btnSuplidores_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(44, 258);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(196, 46);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnPapelera
            // 
            btnPapelera.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPapelera.Location = new Point(44, 337);
            btnPapelera.Name = "btnPapelera";
            btnPapelera.Size = new Size(196, 46);
            btnPapelera.TabIndex = 4;
            btnPapelera.Text = "Papelera";
            btnPapelera.UseVisualStyleBackColor = true;
            btnPapelera.Click += btnPapelera_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(44, 417);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(196, 46);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes LINQ";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(44, 497);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(196, 46);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(lblProductos);
            panelDashboard.Controls.Add(lblSuplidores);
            panelDashboard.Controls.Add(lblCategorias);
            panelDashboard.Controls.Add(label3);
            panelDashboard.Controls.Add(label2);
            panelDashboard.Controls.Add(label1);
            panelDashboard.Location = new Point(406, 369);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(317, 174);
            panelDashboard.TabIndex = 7;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(173, 137);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(22, 25);
            lblProductos.TabIndex = 5;
            lblProductos.Text = "0";
            // 
            // lblSuplidores
            // 
            lblSuplidores.AutoSize = true;
            lblSuplidores.Location = new Point(173, 79);
            lblSuplidores.Name = "lblSuplidores";
            lblSuplidores.Size = new Size(22, 25);
            lblSuplidores.TabIndex = 4;
            lblSuplidores.Text = "0";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(173, 23);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(22, 25);
            lblCategorias.TabIndex = 3;
            lblCategorias.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 137);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 2;
            label3.Text = "Productos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 1;
            label2.Text = "Suplidores:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "Categorias:";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(745, 597);
            Controls.Add(panelDashboard);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReportes);
            Controls.Add(btnPapelera);
            Controls.Add(btnProductos);
            Controls.Add(btnSuplidores);
            Controls.Add(btnCategorias);
            Controls.Add(lblTitulo);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            Load += FrmMenuPrincipal_Load;
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCategorias;
        private Button btnSuplidores;
        private Button btnProductos;
        private Button btnPapelera;
        private Button btnReportes;
        private Button btnCerrarSesion;
        private Panel panelDashboard;
        private Label label1;
        private Label lblProductos;
        private Label lblSuplidores;
        private Label lblCategorias;
        private Label label3;
        private Label label2;
    }
}