using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto08
{
    public partial class ObtenerOrdenados : Form
    {
        private Fachada f;
        private string comparador;
        public ObtenerOrdenados(Fachada fach, string comp)
        {
            InitializeComponent();
            this.f = fach;
            this.comparador = comp;
        }

        private void ObtenerOrdenados_Load(object sender, EventArgs e)
        {
            List<string[]> usuarios = f.ObtenerOrdenadosPor(this.comparador);
            foreach (string[] us in usuarios)
            {
                dataGridView1.Rows.Add(us[0], us[1], us[2]);
            }
            
        }
    }
}
