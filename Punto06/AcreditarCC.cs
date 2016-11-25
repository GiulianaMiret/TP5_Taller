using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto06
{
    public partial class AcreditarCC : Form
    {
        private Movimientos m = new Movimientos();
        public AcreditarCC(Movimientos mov)
        {
            InitializeComponent();
            this.m = mov;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void AcreditarCC_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(m.VerSaldoCuentaCorriente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= "")
            {
                m.AcreditarSaldoCuentaCorriente(Convert.ToDouble(textBox1.Text));
                label3.Text = Convert.ToString(m.VerSaldoCuentaCorriente());

                textBox1.Text = "0";
                var t = Task.Delay(1250); //1 second/1000 ms
                t.Wait();
                this.Close();
            }


        }
    }
}
