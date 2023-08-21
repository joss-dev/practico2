namespace practico2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LNombre = new Label();
            LDni = new Label();
            LApellido = new Label();
            LModificar = new Label();
            LNyA = new Label();
            BGuardar = new Button();
            BEliminar = new Button();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TDni = new TextBox();
            BSalir = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(516, 187);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            LNombre.Click += label1_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(414, 52);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 1;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(527, 228);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            LApellido.Click += label3_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.Control;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(527, 89);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 3;
            LModificar.Text = "Modificar";
            LModificar.Click += label4_Click;
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(414, 89);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(107, 15);
            LNyA.TabIndex = 4;
            LNyA.Text = "Nombre y Apellido";
            // 
            // BGuardar
            // 
            BGuardar.Image = (Image)resources.GetObject("BGuardar.Image");
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(38, 296);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(113, 63);
            BGuardar.TabIndex = 5;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Image = (Image)resources.GetObject("BEliminar.Image");
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(202, 296);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(108, 63);
            BEliminar.TabIndex = 6;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(395, 184);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.KeyPress += validacionNombre;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(395, 225);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 8;
            TApellido.KeyPress += validacionApellido;
            // 
            // TDni
            // 
            TDni.Location = new Point(58, 77);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 9;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += validacion;
            // 
            // BSalir
            // 
            BSalir.Image = (Image)resources.GetObject("BSalir.Image");
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(504, 296);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(95, 63);
            BSalir.TabIndex = 11;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TDni);
            panel1.Location = new Point(38, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 236);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 374);
            Controls.Add(panel1);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(TApellido);
            Controls.Add(LDni);
            Controls.Add(LNyA);
            Controls.Add(LModificar);
            Controls.Add(BSalir);
            Controls.Add(BEliminar);
            Controls.Add(TNombre);
            Controls.Add(BGuardar);
            Name = "Form1";
            Text = "Pequeño formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label LDni;
        private Label LApellido;
        private Label LModificar;
        private Label LNyA;
        private Button BGuardar;
        private Button BEliminar;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TDni;
        private Button BSalir;
        private Panel panel1;
    }
}