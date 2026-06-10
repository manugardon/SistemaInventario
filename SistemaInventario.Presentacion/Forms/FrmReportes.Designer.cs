namespace SistemaInventario.Presentacion.Forms
{
    partial class FrmReportes
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
            cmbReportes = new ComboBox();
            dgvReportes = new DataGridView();
            btnGenerar = new Button();
            txtBusqueda = new TextBox();
            label2 = new Label();
            txtPrecioMinimo = new TextBox();
            txtPrecioMaximo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Reportes LINQ";
            // 
            // cmbReportes
            // 
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Items.AddRange(new object[] { "Promedio de precios por categoría", "", "Productos agrupados por categoría", "", "Top suplidores con más productos", "", "Productos por rango de precio", "", "Búsqueda por nombre" });
            cmbReportes.Location = new Point(163, 48);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(312, 33);
            cmbReportes.TabIndex = 1;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(21, 255);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 62;
            dgvReportes.Size = new Size(927, 225);
            dgvReportes.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(389, 535);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(183, 34);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(700, 45);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(248, 31);
            txtBusqueda.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 51);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 5;
            label2.Text = "Valor búsqueda:";
            // 
            // txtPrecioMinimo
            // 
            txtPrecioMinimo.Location = new Point(700, 118);
            txtPrecioMinimo.Name = "txtPrecioMinimo";
            txtPrecioMinimo.Size = new Size(248, 31);
            txtPrecioMinimo.TabIndex = 6;
            // 
            // txtPrecioMaximo
            // 
            txtPrecioMaximo.Location = new Point(700, 188);
            txtPrecioMaximo.Name = "txtPrecioMaximo";
            txtPrecioMaximo.Size = new Size(248, 31);
            txtPrecioMaximo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 121);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 8;
            label3.Text = "Precio minimo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 191);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 9;
            label4.Text = "Precio máximo:";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(969, 608);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrecioMaximo);
            Controls.Add(txtPrecioMinimo);
            Controls.Add(label2);
            Controls.Add(txtBusqueda);
            Controls.Add(btnGenerar);
            Controls.Add(dgvReportes);
            Controls.Add(cmbReportes);
            Controls.Add(label1);
            Name = "FrmReportes";
            Text = "FrmReportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbReportes;
        private DataGridView dgvReportes;
        private Button btnGenerar;
        private TextBox txtBusqueda;
        private Label label2;
        private TextBox txtPrecioMinimo;
        private TextBox txtPrecioMaximo;
        private Label label3;
        private Label label4;
    }
}