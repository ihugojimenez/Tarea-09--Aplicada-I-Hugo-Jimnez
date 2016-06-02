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
    public partial class StarsForm : Form
    {
        enum estrellas {ProtoEstrella, EstrellaTTauri, EstrellaDeSecuenciaPrincpal, GiganteRoja, EnanaBlanca, EnanaRoja, SuperGigante}
        estrellas star;

        public StarsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int ae=0; ae<6; ae++)
            {
                StarsrichTextBox.Text = star.ToString() + "\n";
            }
            
        }
    }
}
