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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechadateTimePicker.Value;

            DiatextBox.Text = fecha.Day.ToString();
            MestextBox.Text = fecha.ToString("MMMM");
            AniotextBox.Text = fecha.Year.ToString();    
            SemanatextBox.Text = fecha.ToString("dddd");
            //Decimal numero = 0;
            //numero.ToString("M");

            int numeroDias = Convert.ToInt32(DiastextBox.Text);
            DateTime fechaActual = DateTime.Now;

            CitatextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();
            int diasresta = Convert.ToInt32(DiastextBox.Text);
            NuevaFechatextBox.Text = fecha.AddDays(-diasresta).ToLongDateString();

            //Esto se hizo despues del private int...
            MessageBox.Show("La edad es: " + DevolverEdad(fecha));
            DevolverEdad(fecha);
        }
        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento  >= fechaActual)
                    {
                     return 0;
                    }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                    // edad = edad - 1;
                    //edad - = 1;
                }
                return edad;
            }
          
        }
    }
}
