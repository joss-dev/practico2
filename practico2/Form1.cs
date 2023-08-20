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

        private void BGuardar_Click(object sender, EventArgs e)
        {

            LModificar.Text = TApellido.Text + " " + TNombre.Text;


            bool vacio = false;
            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    if(c.Text == string.Empty)
                    {
                        vacio = true;
                        break;
                    }
                }
            }
            if(vacio)
            {
                Interaction.MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "error");
            }
        }
    }
}