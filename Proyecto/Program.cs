using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {            
            string path = "Productos.txt";
            string pathBinario = "ProductosBinario.dat";  
            List<Producto> productos =  new List<Producto>()
            {
                new Producto("1A","Sabritas",12.50m,1,100),
                new Producto("1B","Ruffles",13,2,150),
                new Producto("1C","Doritos",14.50m,3,1200),
                new Producto("1D","Paketaxo",17.50m,5,1000),
                new Producto("1A","Barritas de fresa",7.50m,1,1500),
                new Producto("2A","Emperador de limón",10.50m,2,0),
                new Producto("2B","Gelletas María",6.50m,3,110),
            };

            Console.WriteLine("¡Bienvenido al programa de productos!");            
            if(!File.Exists(path))
            {
                ProductoDB.GuardadarTexto(productos,path);
                Console.WriteLine("Productos.txt creado...");   
            }

            if(!File.Exists(pathBinario))
            {
                ProductoDB.GuardarTextoBinario(productos,pathBinario);
                Console.WriteLine("ProductosBinario.txt creado...\n");     
            } 

            Console.WriteLine("Método GetDepartment con 1 como parámetro\n");
            ProductoDB.GetDepartment(1, path);
            
            Console.WriteLine("Leer los productos de un archivo y ordenarlos por likes\n");
            ProductoDB.ImprimirProductosPorLikes(path);
        }
    }
}
