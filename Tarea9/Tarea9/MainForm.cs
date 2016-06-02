using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CuentaBancaria cb = new CuentaBancaria();

            cb.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Enlace enl = new Enlace();
            enl.Show();
        }

        private void tiposDeNeumaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeumaticoForm nf = new NeumaticoForm();
            nf.Show();
        }
    }
}
