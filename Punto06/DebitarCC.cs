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
    public partial class DebitarCC : Form
    {
        private Movimientos m;

        public DebitarCC(Movimientos mov)
        {
            InitializeComponent();
            this.m = mov; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                try
                {
                    m.DebitarSaldoCuentaCorriente(Convert.ToDouble(textBox1.Text));
                }
                catch (NoHaySuficienteSaldo)
                {
                    MessageBox.Show("No hay suficiente saldo");
                }
                label5.Text = Convert.ToString(m.VerSaldoCuentaCorriente());
                textBox1.Text = "0";
                var t = Task.Delay(1250); //1 second/1000 ms
                t.Wait();
                this.Close();
            }
        }

        private void DebitarCC_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(m.VerSaldoCuentaCorriente());
        }
    }
}
