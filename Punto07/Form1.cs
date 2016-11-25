using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto07
{
    public partial class Form1 : Form
    {
        private Fachada f = new Fachada();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string elem in f.TodosLosEncriptadores())
            {
                comboBox1.Items.Add(elem);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                String seleccionado = comboBox1.SelectedItem.ToString();
                switch (seleccionado)
                {
                    case "AES":
                        textBox1.Text = f.EncriptarAES(textBox1.Text);
                        break;
                    case "Cesar":
                        textBox1.Text = f.EncriptarCesar(textBox1.Text, 5);
                        break;
                    case "Nulo":
                        textBox1.Text = f.EncriptarNulo(textBox1.Text);
                        break;
                    case "RSA":
                        textBox1.Text = f.EncriptarRSA(textBox1.Text);
                        break;
                    case "Transposicion":
                        textBox1.Text = f.EncriptarTranspuesto(textBox1.Text);
                        break;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String seleccionado = comboBox1.SelectedItem.ToString();
                switch (seleccionado)
                {
                    case "AES":
                        textBox1.Text = f.DesencriptarAES(textBox1.Text);
                        break;
                    case "Cesar":
                        textBox1.Text = f.DesencriptarCesar(textBox1.Text, 5);
                        break;
                    case "Nulo":
                        textBox1.Text = f.DesencriptarNulo(textBox1.Text);
                        break;
                    case "RSA":
                        textBox1.Text = f.DesencriptarRSA(textBox1.Text);
                        break;
                    case "Transposicion":
                        textBox1.Text = f.DesencriptarTranspuesto(textBox1.Text);
                        break;
                }

            }
        }
    }
}
