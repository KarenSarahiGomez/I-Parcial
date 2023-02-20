namespace POO
{
    public class Coche //Internal es modificar de accceso que esta solo dentro de namespa..
    {
        //Atributos: caracteristicas de la clase y siempre van a ser privados
        private string marca;
        private string modelo;
        //private string precio;


        //Propiedades: ayudan a acceder a los atributos o darle valores
        //get: retorno el valor del atributo o sea marca //set: manda informacion o establecemos el valor 
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo { get => modelo; set { modelo = value; } } //Forma mas corta de creae las propiedades
        public decimal Precio { get; set; } // Se ahorra crear el atributo precio, Forma mas cortita
        public int Kilometros { get; set; }    //Propiedades


        //Constructores siempre publicos y van a llevar el nombre de la clase}
        public Coche() { }
        public Coche(string _marca, string _modelo) //Instanciando, son parametros se puede colocar el nombre que deseemos
        {
            Marca = _marca;
            Modelo = _modelo;
        }

        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }


        //Metodos: funciones que va a realizar
        public string DevolverDatosBasicos()
        {
            return "Marca: " + Marca + "Modelo: " + Modelo + "Precio: " + Precio;

        }
    }
}
