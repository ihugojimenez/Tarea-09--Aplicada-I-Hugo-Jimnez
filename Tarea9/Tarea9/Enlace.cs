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
    public partial class Enlace : Form
    {
        int cont = 0;
        Persona[] dato = new Persona[10];
        public struct Animal
        {
            public string tipo;
            public string raza;
            public string nombre;
            public char sexo;

            public Animal(string tip, string ra, string nomb, char sex)
            {
                tipo = tip;
                raza = ra;
                nombre = ra;
                sexo = sex;
            }

        }

        public struct Persona
        {
            public string Nombre;
            public string Direccion;
            public char Sexo;
            public string Telefono;
            public Animal Mascota;

            public Persona(string pnombre, string dir, char psex, string tel, string atip, string ara, string anomb, char asex)
            {
                Nombre = pnombre;
                Direccion = dir;
                Sexo = psex;
                Telefono = tel;
                Mascota = new Animal(atip, ara, anomb, asex);
            }
        }

        public void limpiar()
        {
            NombreTextBox.Text = "";
            NombreAnimaltextBox.Text = "";
            DirTextBox.Text = "";
            SexAnimaltextBox.Text = "";
            SextextBox.Text = "";
            TelTextBox.Text = "";
            RazaTextBox.Text = "";
            TypeTextBox.Text = "";
        }

        public void mostrar()
        {
            StringBuilder sb = new StringBuilder("Nombre del dueño" + "\t" + "Direccion" + "\t" + "Sexo" + "\t"+ "Telefono" + "\t" + "Tipo" + "\t" + "Raza de la mascota" + "\t" + "MNombre de la mascota" + "\t" + "Sexo de la mascota" + "\t" + "\n" + "\n");
            for (int ae = 0; ae < dato.Length; ae++)
            {
                sb.Append(dato[ae].Nombre + "\t" + dato[ae].Direccion + "\t" + dato[ae].Sexo + "\t" + dato[ae].Telefono + "\t" + dato[ae].Mascota.tipo + "\t" + dato[ae].Mascota.raza + "\t" + dato[ae].Mascota.nombre + "\t" + dato[ae].Mascota.sexo + "\n");
                SalidarichTextBox.Text = sb.ToString();
            }
        }

        public Enlace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(dato[cont].Nombre=NombreTextBox.Text, dato[cont].Direccion=DirTextBox.Text, dato[cont].Sexo=Convert.ToChar(SextextBox.Text), dato[cont].Telefono=TelTextBox.Text, dato[cont].Mascota.tipo=TypeTextBox.Text, dato[cont].Mascota.raza=RazaTextBox.Text, dato[cont].Mascota.nombre=NombreAnimaltextBox.Text, dato[cont].Mascota.sexo=Convert.ToChar(SexAnimaltextBox.Text));
            limpiar();
            cont++;
            mostrar();
        }
    }
}
