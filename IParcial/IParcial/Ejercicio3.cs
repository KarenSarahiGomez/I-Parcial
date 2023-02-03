using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            string cadena = CadenatextBox.Text;

            LongitudtextBox.Text = cadena.Length.ToString();
            PrimerCaractertextBox.Text = cadena.Substring(0, 1);
            UltimoCaractertextBox.Text = cadena.Substring(cadena.Length - 1, 1);
            MayusculastextBox.Text = cadena.ToUpper();
            MinusculastextBox.Text = cadena.ToLower();

            cadena.ToUpper();
            ReemplazartextBox.Text = cadena.ToUpper().Replace("A", "E").ToLower();
            
        }
    }
}
