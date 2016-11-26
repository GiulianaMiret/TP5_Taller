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
    public partial class ObtenerPorCodigo : Form
    {
        private Fachada f;
        public ObtenerPorCodigo(Fachada fach)
        {
            InitializeComponent();
            this.f = fach;
        }

        private void ObtenerPorCodigo_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    string[] us = f.ObtenerPorCodigo(textBox1.Text);
                    label4.Text = us[0];
                    label5.Text = us[1];
                    
                }
                else
                {
                    MessageBox.Show("Ingrese código del usuario");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo encontrar el usuario.");
                textBox1.Text = "";
            }

        }
    }
}
