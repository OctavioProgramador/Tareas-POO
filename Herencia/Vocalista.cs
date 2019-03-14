using System;

namespace Herencia
{
    class Vocalista: Musico
    {
       public Vocalista(string nombre):base(nombre){}
        public override string Saludo(){
            return $"Hola soy {nombre} y soy cantante!!, uooooooh.";
        }    
    }
}