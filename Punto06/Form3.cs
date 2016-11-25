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
    public partial class Form3 : Form
    {
        private Movimientos m;

        public Form3(Movimientos mov)
        {
            InitializeComponent();
            this.m = mov;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(m.VerSaldoCuentaCorriente()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcreditarCC acreditarCuentaCorriente = new AcreditarCC(this.m);
            acreditarCuentaCorriente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DebitarCC debitarCuentaCorriente = new DebitarCC(this.m);
            debitarCuentaCorriente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transferirCC transfDesdeCC = new transferirCC(this.m);
            transfDesdeCC.Show();
        }
    }
}
