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
    public partial class CuentaBancaria : Form
    {
        int cont = 0;
        Cuentas[] dato = new Cuentas[5];

        public struct Cuentas
        {
            public string Nombre;
            public string Numero;
            public string Agencia;
            public string Tipo;
            public string LinCred;
            public string Moneda;
            public string Estado;
            public string CuentaCont;

            public Cuentas(string nomb, string num, string age, string tip, string Lc, string mon, string est, string CC)
            {
                Nombre = nomb;
                Numero = num;
                Agencia = age;
                Tipo = tip;
                LinCred = Lc;
                Moneda = mon;
                Estado = est;
                CuentaCont = CC;

                
            }
        }

        void limpiar()
        {
            NombreTextBox.Text = "";
            NumeroTextBox.Text = "";
            AgenciaTextBox.Text = "";
            TypeTextBox.Text= "";
            LinCredTextBox.Text = "";
            MonedaTextBox.Text = "";
            EstadoTextBox.Text = "";
            CCTextBox.Text = "";
         }


        public void mostrar()
        {
            StringBuilder sb = new StringBuilder("Numero" + "\t" + "Nombre" + "\t" + "Agencia" + "Tipo" + "\t" + "Linea de credito" + "\t" + "Estado" + "\t" + "Moneda" + "\t" + "Cuenta contable" + "\t" + "\n" + "\n");
            //MostrarRichTextBox.Text = "Numero" + "\t" + "Nombre" + "\t" + "Agencia" + "Tipo" + "\t" + "Linea de credito" + "\t" + "Estado" + "\t" + "Moneda" + "\t" + "Cuenta contable" + "\t" + "\n" + "\n";
            for (int ae = 0; ae < dato.Length; ae++)
            {
                sb.Append(dato[ae].Numero + "\t" + dato[ae].Nombre + "\t" + dato[ae].Agencia + "\t" + dato[ae].Tipo + "\t" + dato[ae].LinCred +"\t"+ dato[ae].Estado + "\t" + dato[ae].Moneda + "\t" +dato[ae].CuentaCont + "\n");
                MostrarRichTextBox.Text = sb.ToString();
            }
        }







        public CuentaBancaria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuentas c = new Cuentas(dato[cont].Nombre = NombreTextBox.Text, dato[cont].Numero = NumeroTextBox.Text, dato[cont].Agencia = AgenciaTextBox.Text, dato[cont].Tipo = TypeTextBox.Text, dato[cont].LinCred = LinCredTextBox.Text, dato[cont].Moneda = MonedaTextBox.Text, dato[cont].Estado = EstadoTextBox.Text, dato[cont].CuentaCont = CCTextBox.Text);
            limpiar();
            cont++;
            mostrar();

        }
    }
}
