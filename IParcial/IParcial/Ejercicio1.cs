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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        
        decimal sumaTotal;

        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            //Variables 
            decimal numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox.Text);

            //decimal resultado = numero1 + numero2;

            //decimal resultado = Convert.ToDecimal(Numero1textBox.Text) + Convert.ToDecimal(Numero2textBox.Text);
            //string valor1 = Numero1textBox.Text;
            //Resultadolabel.Text = Convert.ToString(resultado);

            //MessageBox.Show("La suma es: " + resultado);

            //Sumar(numero1, numero2);
            sumaTotal = Sumatoria (numero1,numero2);     //Valor que va a retornar 
            MessageBox.Show("La suma es: " + sumaTotal, "Mensaje", MessageBoxButtons. OK, MessageBoxIcon.Information);
        }

        //Procedimiento
        private void Sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;

        }

        //Funcion
        private decimal Sumatoria(decimal num1, decimal num2)
        {
            //decimal n1, n2, suma;
            //n1 = num1;
            //n2 = num2;
            //suma = num1 + num2;
            //return suma; 
            //Tambien se puede hacer de la manera anterior.......

            return num1 + num2;
        }

    }
}
