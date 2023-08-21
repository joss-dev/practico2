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
            CNaranja = new CheckBox();
            CVisa = new CheckBox();
            CMastercard = new CheckBox();
            label1 = new Label();
            TTelefono = new TextBox();
            LTelefono = new Label();
            RVaron = new RadioButton();
            RMujer = new RadioButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(19, 114);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(59, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "* Nombre";
            LNombre.Click += label1_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(19, 73);
            LDni.Name = "LDni";
            LDni.Size = new Size(35, 15);
            LDni.TabIndex = 1;
            LDni.Text = "* DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(19, 160);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(59, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "* Apellido";
            LApellido.Click += label3_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.Control;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(137, 24);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 3;
            LModificar.Text = "Modificar";
            LModificar.Click += label4_Click;
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(13, 24);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(107, 15);
            LNyA.TabIndex = 4;
            LNyA.Text = "Nombre y Apellido";
            // 
            // BGuardar
            // 
            BGuardar.Image = (Image)resources.GetObject("BGuardar.Image");
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(57, 521);
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
            BEliminar.Location = new Point(188, 521);
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
            TNombre.Location = new Point(122, 114);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.KeyPress += validacionNombre;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(122, 160);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 8;
            TApellido.KeyPress += validacionApellido;
            // 
            // TDni
            // 
            TDni.Location = new Point(122, 73);
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
            BSalir.Location = new Point(504, 521);
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
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(CNaranja);
            panel1.Controls.Add(CVisa);
            panel1.Controls.Add(CMastercard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LNyA);
            panel1.Controls.Add(LModificar);
            panel1.Location = new Point(38, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 380);
            panel1.TabIndex = 12;
            // 
            // CNaranja
            // 
            CNaranja.AutoSize = true;
            CNaranja.Location = new Point(122, 262);
            CNaranja.Name = "CNaranja";
            CNaranja.Size = new Size(67, 19);
            CNaranja.TabIndex = 15;
            CNaranja.Text = "Naranja";
            CNaranja.UseVisualStyleBackColor = true;
            // 
            // CVisa
            // 
            CVisa.AutoSize = true;
            CVisa.Location = new Point(122, 296);
            CVisa.Name = "CVisa";
            CVisa.Size = new Size(47, 19);
            CVisa.TabIndex = 14;
            CVisa.Text = "Visa";
            CVisa.UseVisualStyleBackColor = true;
            // 
            // CMastercard
            // 
            CMastercard.AutoSize = true;
            CMastercard.Location = new Point(122, 331);
            CMastercard.Name = "CMastercard";
            CMastercard.Size = new Size(85, 19);
            CMastercard.TabIndex = 13;
            CMastercard.Text = "Mastercard";
            CMastercard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 244);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 12;
            label1.Text = "Tarjetas de credito: ";
            label1.Click += label1_Click_1;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(122, 206);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 11;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(19, 209);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 10;
            LTelefono.Text = "Telefono";
            // 
            // RVaron
            // 
            RVaron.AutoSize = true;
            RVaron.Checked = true;
            RVaron.Location = new Point(366, 249);
            RVaron.Name = "RVaron";
            RVaron.Size = new Size(55, 19);
            RVaron.TabIndex = 13;
            RVaron.TabStop = true;
            RVaron.Text = "Varon";
            RVaron.UseVisualStyleBackColor = true;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.Location = new Point(477, 249);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(56, 19);
            RMujer.TabIndex = 14;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(396, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 113);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(168, 21);
            label2.Name = "label2";
            label2.Size = new Size(253, 47);
            label2.TabIndex = 16;
            label2.Text = "Nuevo Cliente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 596);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(RMujer);
            Controls.Add(RVaron);
            Controls.Add(panel1);
            Controls.Add(BSalir);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Form1";
            Text = "Pequeño formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label1;
        private TextBox TTelefono;
        private Label LTelefono;
        private CheckBox CNaranja;
        private CheckBox CVisa;
        private CheckBox CMastercard;
        private RadioButton RVaron;
        private RadioButton RMujer;
        private PictureBox pictureBox1;
        private Label label2;
    }
}