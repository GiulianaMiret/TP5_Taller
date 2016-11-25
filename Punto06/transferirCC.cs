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
    public partial class transferirCC : Form
    {
        private Movimientos m;
        public transferirCC(Movimientos mov)
        {
            InitializeComponent();
            this.m = mov;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    m.TransferirCuentaCorrienteACajaAhorro(Convert.ToDouble(textBox1.Text));

                    label5.Text = Convert.ToString(m.VerSaldoCajaAhorro());
                    label4.Text = Convert.ToString(m.VerSaldoCuentaCorriente());

                    textBox1.Text = "0";
                    var t = Task.Delay(1750); //1 second/1000 ms
                    t.Wait();
                    this.Close();

                }
            }
            catch(NoHaySuficienteSaldo)
            {
                MessageBox.Show("No hay suficiente saldo");
                textBox1.Text = "0";
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
                textBox1.Text = "0";
            }

        }

        private void transferirCC_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(m.VerSaldoCajaAhorro());
            label4.Text = Convert.ToString(m.VerSaldoCuentaCorriente());
            textBox1.Text = "0";

        }
    }
}
