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
    public partial class Acreditar : Form
    {
        Movimientos m = new Movimientos();
        public Acreditar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                m.AcreditarSaldoCajaAhorro(Convert.ToDouble(textBox1.Text));
                label3.Text = Convert.ToString(m.VerSaldoCajaAhorro());
            }
        }

        private void Acreditar_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(m.VerSaldoCajaAhorro());
        }
    }
}
