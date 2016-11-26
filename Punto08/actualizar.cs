using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto08
{
    public partial class actualizar : Form
    {
        private Fachada f;
        public actualizar(Fachada fach)
        {
            InitializeComponent();
            this.f = fach;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text!="" && textBox2.Text!= "" && textBox3.Text!= "")
                {
                    string cod = textBox1.Text;
                    string nom = textBox2.Text;
                    string cor = textBox3.Text;
                    f.ActualizarUsuario(cod, nom, cor);
                    MessageBox.Show("Usuario actualizado.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ese codigo de usuario no existe.");
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = f.MostrarNombre(textBox1.Text);
            textBox3.Text = f.MostrarCorreo(textBox1.Text);
        }
    }
}
