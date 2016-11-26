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
    public partial class Form1 : Form
    {
        private Fachada f = new Fachada();
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2(f);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizar newMDIChild = new actualizar(f);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar newMDIChild = new Eliminar(f);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void obtenerPorCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerPorCodigo newMDIChild = new ObtenerPorCodigo(f);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void obtenerOrdenadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void obtenerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerTodos newMDIChild = new ObtenerTodos(f);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenadosPor("");
        }



        private void OrdenadosPor(string comp)
        {
            ObtenerOrdenados newMDIChild = new ObtenerOrdenados(f,comp);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenadosPor("Nombre");
        }

        private void porNombreYCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenadosPor("NombreyCodigo");
        }

        private void porCorreoElectronicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenadosPor("CorreoElectronico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
