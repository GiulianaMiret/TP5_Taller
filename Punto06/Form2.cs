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
    public partial class Form2 : Form
    {
        Movimientos m = new Movimientos();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(m.VerSaldoCajaAhorro()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debitar form3 = new Debitar();

            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acreditar form4 = new Acreditar();
            form4.Show();
        }
    }
}
