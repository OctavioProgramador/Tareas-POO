using System;

namespace Herencia
{
    class Bajista : Musico
    {
        public string bajo;
        public Bajista(string nombre, string bajo):base(nombre)
        {
            this.bajo = bajo;
        }
        public override string Saludo(){
            return base.Saludo()+" y soy bajista, y mi bajo es "+bajo;
        }
     } 
}