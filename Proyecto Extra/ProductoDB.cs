using System;
using System.IO;
using System.Collections.Generic;

namespace Proyecto_Extra
{
    class ProductoDB
    {
        public static void GuardadarTexto(List<Producto> productos, string path)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                foreach(Producto producto in productos)
                {
                    streamWriter.Write(producto.Codigo+"|");
                    streamWriter.Write(producto.Descripcion+"|");                 
                    streamWriter.Write(producto.Precio+"|");                    
                    streamWriter.Write(producto.Departamento+"|");                    
                    streamWriter.WriteLine(producto.Likes);                    
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

               if(!(streamWriter == null))
                    streamWriter.Close();
            }
        }

        public static List<Producto> LeerTexto(string path)
        {
            List<Producto> productos = new List<Producto>();
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fileStream);
                while(streamReader.Peek()!=-1)
                {                    
                    string fila = streamReader.ReadLine();
                    string[] columna = fila.Split("|");
                    Producto producto 
                    = new Producto(columna[0],columna[1],
                    Convert.ToDecimal(columna[2]),
                    Convert.ToInt16(columna[3]), Convert.ToInt16(columna[4]));
                    productos.Add(producto);
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
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return productos;
        }

        public static void GuardarTextoBinario(List<Producto> productos, string path)
        {
            FileStream fileStream = null;
            BinaryWriter binaryWriter = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                binaryWriter = new BinaryWriter(fileStream);
                foreach(Producto producto in productos)
                {
                    binaryWriter.Write(producto.Codigo);
                    binaryWriter.Write(producto.Descripcion);                 
                    binaryWriter.Write(producto.Precio);                    
                    binaryWriter.Write(producto.Departamento);                    
                    binaryWriter.Write(producto.Likes);                    
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
               if(!(binaryWriter == null))
                    binaryWriter.Close();
            }
        }

        public static void GetDepartment(int Depto, string path)
        {
            List<Producto> productos = LeerTexto(path);
            foreach(Producto productoDeseado in productos)
            {
                if(productoDeseado.Departamento == Depto)
                Console.WriteLine(productoDeseado);
            } 
        }

        public static void ImprimirProductosPorLikes(string path)
        {
            List<Producto> productos = LeerTexto(path);
            productos.Sort();
            foreach(Producto productoOrdenado in productos)            
                Console.WriteLine(productoOrdenado);            
        }    
    }
}