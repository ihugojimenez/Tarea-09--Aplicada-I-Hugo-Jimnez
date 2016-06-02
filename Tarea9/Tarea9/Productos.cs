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
    public partial class Productos : Form
    {

        public struct Articulos
        {
            public string Descripcion;
            public int codigo;
            public float precio;

            public Articulos(string desc, int cod, float prc)
            {
                Descripcion = desc;
                codigo = cod;
                precio = prc;
            }
        }

        int cont = 0;
        Articulos[] data = new Articulos[20];

        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            data[cont].codigo = Convert.ToInt32(CodTextBox.Text);
            data[cont].Descripcion = DescTextBox.Text;
            data[cont].precio = Convert.ToSingle(PrcTextBox.Text);
            DescTextBox.Text = " ";
            CodTextBox.Text = " ";
            PrcTextBox.Text = " ";
            cont++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            MostrarRichTextBox.Text = "Codigo" + "\t" + "Descripcion" + "\t" + "Precio" + "\n" + "\n";  
            for(int ae=0; ae< data.Length; ae++)
            {
                sb.Append(data[ae].codigo + "\t" + data[ae].Descripcion + "\t" + data[ae].precio + "\n");
                MostrarRichTextBox.Text = sb.ToString(); 
            }
        }
    }
}
