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
            realizarTarea();

        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(150, 90);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
        }


    }

}