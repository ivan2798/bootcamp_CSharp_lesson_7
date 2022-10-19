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

           ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiValorEuro(1.45);

            Console.WriteLine(obj.convierte(50));
            

        }


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
