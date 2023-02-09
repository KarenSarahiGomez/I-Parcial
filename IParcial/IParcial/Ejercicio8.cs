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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorreDeUnoEnUno(1, 100);
        } 

        //Función recursiva
        private void RecorreDeUnoEnUno(int valInicial, int valFinal)
        {
            listBox1.Items.Add(valInicial);
            if (valInicial < valFinal)
            {
                RecorreDeUnoEnUno(valInicial + 1, valFinal);
            }
        }
    }
}
