using Microsoft.VisualBasic;
using System.Net;

namespace practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                Interaction.MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "error");
            }
            else
            {
                MsgBoxResult ask = Interaction.MsgBox("Seguro desea ingresar un nuevo cliente?", MsgBoxStyle.YesNo, "Confirmacion de insersion");
                if (ask == MsgBoxResult.Yes)
                {
                    Interaction.MsgBox("El cliente " + LModificar.Text + " se inserto correctamente", MsgBoxStyle.Information, "Guardar");
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
                Interaction.MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "error");
            }
            else
            {
                MsgBoxResult result = Interaction.MsgBox("Estas a punto de eliminar el cliente: " + TApellido.Text + " " + TNombre.Text, MsgBoxStyle.YesNo, "Confirmacion de eliminacion");
                if (result == MsgBoxResult.Yes)
                {
                    LModificar.Text = "Modificar";
                    Interaction.MsgBox("El cliente: " + TApellido.Text + " " + TNombre.Text + " se elimino correctamente", MsgBoxStyle.Information, "Eliminacion");
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}