using POO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }
        Coche miCoche = null;
        List<Coche> ListaCoches = new List<Coche>();
        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche(); //Constructor vacío
            //Coche miCoche2 = new Coche("Toyota", "22R");

            string marca = MarcatextBox.Text;
            string modelo = ModelotextBox.Text;
            decimal precio;
            if (PreciotextBox.Text == string.Empty)
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDecimal(PreciotextBox.Text);
            }
            int km = KilometrostextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrostextBox.Text);
            // ? entonces, =: si no

            miCoche = new Coche();  //Intanciar

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = km;

            ListaCoches.Add(miCoche);
            CochesdataGridView.DataSource = null;
            CochesdataGridView.DataSource = ListaCoches;
            LimpiarControles();
            MarcatextBox.Focus(); //Limpiar y agregar a la lista 
            //MessageBox.Show("Objeto coche -> Marca: " + miCoche.Marca + "Modelo: " + miCoche.Modelo);
        }
        private void LimpiarControles()
        {
            MarcatextBox.Clear(); //Formas de limpiar
            ModelotextBox.Text = string.Empty;
            PreciotextBox.Text = "";
            KilometrostextBox.Clear();

        }
        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            //MarcatextBox.Focus();
        }
    }
}
