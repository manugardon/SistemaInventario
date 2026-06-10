namespace SistemaInventario.Presentacion.Forms
{
    partial class FrmRegistro
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
            txtUsuario = new TextBox();
            label1 = new Label();
            txtClave = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(359, 170);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(194, 31);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 170);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingrese Nuevo Usuario:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(359, 257);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(194, 31);
            txtClave.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 263);
            label2.Name = "label2";
            label2.Size = new Size(223, 25);
            label2.TabIndex = 3;
            label2.Text = "Ingrese Nueva Contraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(287, 366);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 36);
            label3.Name = "label3";
            label3.Size = new Size(318, 33);
            label3.TabIndex = 5;
            label3.Text = "REGISTRO DE USUARIO";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(749, 450);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Name = "FrmRegistro";
            Text = "FrmRegistro";
            Load += FrmRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtClave;
        private Label label2;
        private Button btnGuardar;
        private Label label3;
    }
}