namespace SistemaInventario.Presentacion.Forms
{
    partial class FrmPapelera
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
            cmbTipo = new ComboBox();
            btnRestaurar = new Button();
            dgvPapelera = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPapelera).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Categorías", "", "Suplidores", "", "Productos" });
            cmbTipo.Location = new Point(22, 198);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(182, 33);
            cmbTipo.TabIndex = 0;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged_1;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(45, 311);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(112, 34);
            btnRestaurar.TabIndex = 1;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // dgvPapelera
            // 
            dgvPapelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPapelera.Location = new Point(244, 129);
            dgvPapelera.Name = "dgvPapelera";
            dgvPapelera.RowHeadersWidth = 62;
            dgvPapelera.Size = new Size(681, 225);
            dgvPapelera.TabIndex = 2;
            dgvPapelera.CellClick += dgvPapelera_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 160);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 3;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(398, 32);
            label2.Name = "label2";
            label2.Size = new Size(131, 29);
            label2.TabIndex = 4;
            label2.Text = "PAPELERA";
            // 
            // FrmPapelera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPapelera);
            Controls.Add(btnRestaurar);
            Controls.Add(cmbTipo);
            Name = "FrmPapelera";
            Text = "FrmPapelera";
            Load += FrmPapelera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPapelera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Button btnRestaurar;
        private DataGridView dgvPapelera;
        private Label label1;
        private Label label2;
    }
}