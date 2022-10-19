using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

// Hello World! program
namespace bootcamp_CSharp_lesson_7
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto/instancia de tipo Coche.
            //dar un estado inical a nuestro coche

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.getInfoCoche());

            coche3.setExtras(true, "cuero");

            Console.WriteLine(coche3.getExtras());

        }


    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

            tapiceria = "tela";

        }

        public Coche(double largo, double ancho)
        {
            this.ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            this.tapiceria = "tela";
        }
    }

    partial class Coche
    { 

        public string getInfoCoche()
        {
            return $"Informacion del coche: Ruedas: {ruedas}, Largo: {largo}, Ancho:{ancho} ";
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;
        } 

        public string getExtras()
        {
            return $"Extras del coche: Tapicería {tapiceria}, Climatizador {climatizador}";
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;
    }
    class Circulo
    {

        private const double PI = 3.1216;  //propiedad de la clase Círculo. Campo de clase.

        public double CalculoArea(int radio) // método de cla. ¿Qué pueden hacer los objetos de tipo círculo?
        {

            return PI * radio * radio;
        }
     
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambiValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else
                euro = nuevoValor;
        }
    }
}
