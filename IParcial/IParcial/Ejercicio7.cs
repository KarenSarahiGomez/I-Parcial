using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace IParcial
{
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            //Matriz [3 y 3 es decir 3 filas y 3 columnas]
            int[,] matriz1 = new int[3, 3] {
                { 3, 6, 3 },
                { 6, 9, 7 },
                { 8, 9, 4 }
                                           };
            Random random = new Random();

            int valorFila = Convert.ToInt32(filatextBox.Text); 
            int valorColumna = Convert.ToInt32(columnatextBox.Text);
            //Next genera valores aleatorios internos 100, 2000, etc.


            int[,] matriz2 = new int[valorFila, valorColumna]; 
            //get lenhgt para aumentar el tamaño de la mtriz

            //Llenando la matriz 
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = random.Next(1, 100); //(en la posc.)
                }
            }

            //Mostrando los valores de la matriz en el textBox
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posición: ["+fila+","+columna+"] = " + matriz2[fila, columna]);
                }
            }

            textBox1.Text = matriz2.GetLength(0).ToString() + "x" + matriz2.GetLength(1).ToString();
        }
    }
}
