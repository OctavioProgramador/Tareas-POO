using System;
using System.Collections.Generic;

namespace Proyecto_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "Productos1.txt";
            string path2 = "Productos2.txt";
            Console.WriteLine("¡Bienvenido a la parte extra del proyecto!");
            ProductoDB.GuardadarTexto(ProductoDB.LeerTexto(path1),path2);
            Console.WriteLine("¡Éxito en la operación!");
        }
    }
}
