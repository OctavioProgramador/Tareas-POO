using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Producto
    {
        public string Codigo{get; set;}
        public string Descripcion{get;set;}
        public decimal Precio{get;set;}
        public int Departamento{get;set;}
        public int Likes{get;set;}        
    }
    class ProductoDB
    {
        public static void GuardadarTexto(List<Producto> productos, string path)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                foreach(Producto producto in productos)
                {
                    Console.Write(producto.Codigo+"|");
                    Console.Write(producto.Descripcion+"|");                 
                    Console.Write(producto.Precio+"|");                    
                    Console.Write(producto.Departamento+"|");                    
                    Console.WriteLine(producto.Likes);                    
                }                
            }        
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("No se encontró el folder");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("No se encontró el archivo");                
            }
            catch(IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                if(!(fileStream == null))
                    fileStream.Close();
               if(!(streamWriter == null))
                    streamWriter.Close();
            }
        }
    }
}
