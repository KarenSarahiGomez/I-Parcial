using System;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        //Error Provider
        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            if (Numero1textBox.Text == "")
            {
                errorProvider1.SetError(Numero1textBox, "Ingrese un valor");
                return;
            }
            if (Numero2textBox.Text == "")
            {
                errorProvider1.SetError(Numero2textBox, "Ingrese un valor");
                return;
            }
            if (OperacionescomboBox.Text == "")
            {
                errorProvider1.SetError(OperacionescomboBox, "Seleccione una opción");
                return;
            }
            errorProvider1.Clear(); //Sig. que limpie los errores //Termina Error Provider 
            decimal resultado = Ejecutar(Convert.ToDecimal(Numero1textBox.Text), Convert.ToDecimal(Numero2textBox.Text));

            Resultadolabel.Text = Convert.ToString(resultado);
        }
        private decimal Ejecutar(decimal n1, decimal n2)
        {
            string operacion = OperacionescomboBox.Text;
            decimal resultado = 0;
            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicación")
            {
                resultado = n1 * n2;
            }
            else if (operacion == "División")
            {
                resultado = n1 / n2;
            }

            return resultado;

        }
    }
}
