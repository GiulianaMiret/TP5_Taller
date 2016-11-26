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
    public partial class Form2 : Form
    {
        private Fachada f;
        
        public Form2( Fachada fach )
        {
            InitializeComponent();
            this.f = fach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    string cod = textBox1.Text;
                    string nom = textBox2.Text;
                    string cor = textBox3.Text;
                    f.AgregarUsuario(cod, nom, cor);
                    MessageBox.Show("Usuario agregado.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos.");
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Ese codigo de usuario ya existe.");
                textBox1.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
