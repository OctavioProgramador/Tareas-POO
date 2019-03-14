using System;
using System.Collections.Generic;
namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            Color rojo = new Color(255,0,0);
            Color azul = new Color(0,0,255);
            Color verde= new Color(0,255,0);
            Color negro= new Color(0,0,0);

            List<Figura> figuras = new List<Figura>()
            {
                new Circulo(negro, verde, 10,100,100),
                new Triangulo(verde, rojo,12,13,100,120),
                new Rectangulo(azul, verde, 12,15,120,120)
            };

            foreach (Figura x in figuras)
            {
                x.Dibuja();
            }

            foreach (Figura x in figuras)
            {
                Console.WriteLine("El área de la figura "+x.Tipo()+ " es "+x.Area());
            }
        }
    }
}
