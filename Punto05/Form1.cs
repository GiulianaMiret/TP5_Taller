using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void SeIngresoValor()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Fachada f = new Fachada();
                Double a = Convert.ToDouble(textBox1.Text);
                Double b = Convert.ToDouble(textBox2.Text);
                Double c = Convert.ToDouble(textBox3.Text);
                label8.Text = Convert.ToString(f.CalcularPerimetroCirculo(a, b, c));
                label9.Text = Convert.ToString(f.CalcularAreaCirculo(a, b, c));
            }
        }

        private void SeIngresoValor2()
        {
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                Fachada f = new Fachada();
                Double a = Convert.ToDouble(textBox4.Text);
                Double b = Convert.ToDouble(textBox5.Text);
                Double c = Convert.ToDouble(textBox6.Text);
                Double d = Convert.ToDouble(textBox7.Text);
                Double e = Convert.ToDouble(textBox8.Text);
                Double g = Convert.ToDouble(textBox9.Text);
                label16.Text = Convert.ToString(f.CalcularPerimetroTriangulo(a, b, c, d, e, g));
                label17.Text = Convert.ToString(f.CalcularAreaTriangulo(a, b, c, d, e, g));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label16.Text = "";
            label17.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor2();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor2();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor2();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor2();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor2();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            SeIngresoValor2();
        }
    }
}
