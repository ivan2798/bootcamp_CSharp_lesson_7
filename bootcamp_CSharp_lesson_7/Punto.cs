﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_CSharp_lesson_7
{
    class Punto
    {
        public Punto(int x, int y)
        {
            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
        }

        public Punto()
        {
            Console.WriteLine($"Constructor por defecto");
        }

    }
}
