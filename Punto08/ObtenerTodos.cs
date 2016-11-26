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
    public partial class ObtenerTodos : Form
    {
        private Fachada f;
        public ObtenerTodos(Fachada fach)
        {
            InitializeComponent();
            this.f = fach;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ObtenerTodos_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            List<string> Usuarios = f.ObtenerTodos();
            foreach (string us in Usuarios)
            {
                textBox1.Text = textBox1.Text + us + "\r\n";
            }
            
        }
    }
}
