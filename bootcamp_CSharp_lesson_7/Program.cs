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

            Circulo miCirculo; // creación de objeto de tipo Círculo. Variable/objeto de tipo círculo.

            miCirculo = new Circulo(); //Iniciación de variable/objeto de tipo Circulo. Instanciar una clase
            //Instanciación. Ejemplarización. Creación de ejemplar de clase.

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));


        }


    }
    class Circulo
    {

        double pi = 3.1216;  //propiedad de la clase Círculo. Campo de clase.

        public double calculoArea(int radio) // método de cla. ¿Qué pueden hacer los objetos de tipo círculo?
        {

            return pi * radio * radio;
        }
     
    }
}
