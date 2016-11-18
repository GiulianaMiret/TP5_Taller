using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String seleccionado = comboBox1.SelectedItem.ToString();
            switch (seleccionado)
            {
                case "uno":
                    label1.Text = "one";
                    break;
                case "dos":
                    label1.Text = "two";
                    break;
                case "tres":
                    label1.Text = "three";
                    break;
                case "cuatro":
                    label1.Text = "four";
                    break;
                case "cinco":
                    label1.Text = "five";
                    break;
                case "seis":
                    label1.Text = "six";
                    break;
                case "siete":
                    label1.Text = "seven";
                    break;
                case "ocho":
                    label1.Text = "eight";
                    break;
                case "nueve":
                    label1.Text = "nine";
                    break;
                case "diez":
                    label1.Text = "ten";
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("uno");
            comboBox1.Items.Add("dos");
            comboBox1.Items.Add("tres");
            comboBox1.Items.Add("cuatro");
            comboBox1.Items.Add("cinco");
            comboBox1.Items.Add("seis");
            comboBox1.Items.Add("siete");
            comboBox1.Items.Add("ocho");
            comboBox1.Items.Add("nueve");
            comboBox1.Items.Add("diez");
            label1.Text = "";


        }

    }
}
