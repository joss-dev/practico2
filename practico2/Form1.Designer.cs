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
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(117, 129);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            LNombre.Click += label1_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(117, 92);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 1;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(117, 170);
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
            LModificar.Location = new Point(259, 34);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 3;
            LModificar.Text = "Modificar";
            LModificar.Click += label4_Click;
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(117, 34);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(107, 15);
            LNyA.TabIndex = 4;
            LNyA.Text = "Nombre y Apellido";
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(117, 214);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 5;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(242, 214);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 6;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(217, 129);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.KeyPress += validacionNombre;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(217, 170);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 8;
            TApellido.KeyPress += validacionApellido;
            // 
            // TDni
            // 
            TDni.Location = new Point(217, 89);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 9;
            TDni.KeyPress += validacion;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 311);
            Controls.Add(TDni);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(LNyA);
            Controls.Add(LModificar);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LNombre);
            Name = "Form1";
            Text = "Pequeño formulario";
            Load += Form1_Load;
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
    }
}