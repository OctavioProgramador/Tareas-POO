using System;

namespace Herencia
{
       class Baterista : Musico{
        public string bateria;
        public Baterista(string nombre, string bateria):base(nombre)
        {
            this.bateria = bateria;
        }
        public override string Saludo(){
            return base.Saludo()+" y soy baterista, y mi bateria es "+bateria;
        }
    }
}