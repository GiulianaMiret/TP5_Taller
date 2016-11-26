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
    public partial class Eliminar : Form
    {
        private Fachada f;
        public Eliminar(Fachada fach)
        {
            InitializeComponent();
            this.f = fach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text!="")
                {
                    f.EliminarUsuario(textBox1.Text);
                    MessageBox.Show("Usuario eliminado.");
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese usuario");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo eliminar usuario.");
                textBox1.Text = "";
            }
        }
    }
}
