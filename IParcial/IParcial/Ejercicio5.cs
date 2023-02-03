using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HornearPizza();
            MessageBox.Show("Mensaje normal");
             
        }
        private void HornearPizza()
        {
            Thread.Sleep(10000);

        }
        private Task HornearPizzaAsincrona()
        {
            return Task.Delay(1000);
        }

        private void HornearAsincronobutton_Click(object sender, EventArgs e)
        {
            HornearPizzaAsincrona();
            MessageBox.Show("Mensaje Asincrono");
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Numero12textBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal total = await SumarAsyn(num1, num2);

            MessageBox.Show($"La suma es: {total}");
        }

        private async Task<decimal> SumarAsyn(decimal n1, decimal n2)  //Task va a retornar
        {
            decimal suma = await Task.Run(() =>                       //Return se almacena en la v decimal
            {
                return n1 + n2;
            });
            return suma;    
        }
    }
}
