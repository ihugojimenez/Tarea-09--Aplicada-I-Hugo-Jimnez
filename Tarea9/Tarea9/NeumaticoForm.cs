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
    public partial class NeumaticoForm : Form
    {

        enum Neumaticos {Anchos=1, XL, Recauchatados, Verano, Invierno, TodoTimepo}
        Neumaticos n = Neumaticos.Invierno;
        Neumaticos n2 = Neumaticos.Anchos;
        Neumaticos n3 = Neumaticos.Recauchatados;
        Neumaticos n4 = Neumaticos.TodoTimepo;
        Neumaticos n5 = Neumaticos.Verano;
        Neumaticos n6 = Neumaticos.XL;
        public NeumaticoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MostrarrichTextBox.Text = "Distintos tipos de neumaticos" +"\n" +Convert.ToString(n) + "\n" + Convert.ToString(n2) + "\n" + Convert.ToString(n3) + "\n" + Convert.ToString(n4) + "\n" + Convert.ToString(n5) + "\n" + Convert.ToString(n6); 
        }
    }
}
