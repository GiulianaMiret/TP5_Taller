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
    public partial class Debitar : Form
    {
        Movimientos m = new Movimientos();
        public Debitar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    m.DebitarSaldoCajaAhorro(Convert.ToDouble(textBox1.Text));
                }
                catch (NoHaySuficienteSaldo)
                {
                    MessageBox.Show("No hay suficiente saldo");
                }

                label3.Text = Convert.ToString(m.VerSaldoCajaAhorro());
                label5.Text = Convert.ToString(m.VerSaldoCuentaCorriente());
            }
        }

        private void Debitar_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label5.Text = "";
        }
    }
}
