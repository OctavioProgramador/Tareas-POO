using System;

namespace Herencia
{
    abstract class Musico
    {
        public string nombre;
        public Musico(string n)
        {
            this.nombre = n;
        }
        /* public void Imprimir(){
            Console.WriteLine(this.Saludo());
        }*/
        public abstract string Saludo();
        /* {
            return "Hola soy "+nommbre;
            return String.Format("Hola, soy {0}", nombre);
        }*/
    }
}