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
    public partial class Form1 : Form
    { 
        private Movimientos m = new Movimientos(); 
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click();
        }

        private void btnOpenForm_Click()
        {
            Form2 frm2 = new Form2(m);
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(m);
            frm3.Show();
        }
    }
}
