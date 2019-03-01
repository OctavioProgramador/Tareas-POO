using System;

namespace Herencia
{
         class Guitarrista : Musico{
        public string guitarra;
        public Guitarrista(string nombre, string guitarra):base(nombre)
        {
            this.guitarra = guitarra;
        }
        public override string Saludo(){
            return base.Saludo()+" y soy guitarrista, y mi guitarra es "+guitarra;
        }
    }
}