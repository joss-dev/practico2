using Microsoft.VisualBasic;

namespace practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidacionTextBoxs()
        {
            bool vacio = false;
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == string.Empty)
                    {
                        vacio = true;
                        break;
                    }
                }
            }
            return vacio;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            LModificar.Text = TApellido.Text + " " + TNombre.Text;

            if (ValidacionTextBoxs())
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                MsgBoxResult ask = (MsgBoxResult) MessageBox.Show("Seguro desea ingresar un nuevo cliente?", "Confirmacion de insersion", MessageBoxButtons.YesNo);
                if (ask == MsgBoxResult.Yes)
                {
                    MessageBox.Show("El cliente " + LModificar.Text + " se inserto correctamente","Guardar" ,MessageBoxButtons.OK);
                }
            }
        }

        private void validacion(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validacionNombre(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void validacionApellido(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBoxs())
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MsgBoxResult result = (MsgBoxResult)MessageBox.Show("Estas a punto de eliminar el cliente: " + TApellido.Text + " " + TNombre.Text, "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (result == MsgBoxResult.Yes)
                {
                    LModificar.Text = "Modificar";
                    Interaction.MsgBox("El cliente: " + TApellido.Text + " " + TNombre.Text + " se elimino correctamente", MsgBoxStyle.Information, "Eliminacion");
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    TTelefono.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SeleccionaMujer(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.mujer;
        }

        private void seleccionaHombre(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.hombre;
        }

        private void validacionTelefono(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(cerrar);
        }

        void cerrar(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                Application.Exit();
            }
        }
    }
}