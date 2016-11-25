using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_TP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "Se ha seleccionado: ";
            if (checkBox1.Checked)
            {
                mensaje += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                mensaje += checkBox2.Text + ", ";
            }

            //
            if (radioButton1.Checked)
            {
                mensaje += radioButton1.Text;
            }
            else { if (radioButton2.Checked) { mensaje += radioButton2.Text; }
                else mensaje += radioButton3.Text;
            }

            MessageBox.Show(mensaje, "Resultados obtenidos");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
