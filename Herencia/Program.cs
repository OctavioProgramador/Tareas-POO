using System;

namespace Herencia
{
     class Musico
    {
        public string nombre;
        public Musico(string n)
        {
            this.nombre = n;
        }
        public virtual string Saludo()
        {
            //return "Hola soy "+nommbre;
            return String.Format("Hola, soy {0}", nombre);
        }
    }
    class Bajista : Musico{
        public string bajo;
        public Bajista(string nombre, string bajo):base(nombre)
        {
            this.bajo = bajo;
        }
        public override string Saludo(){
            return base.Saludo()+" y soy bajista, y mi bajo es "+bajo;
        }
     } 
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
    class Program
    {
        static void Main(string[] args)
        {
            Musico m = new Musico("Lady Gaga");
            Console.WriteLine(m.Saludo());
            Bajista b = new Bajista("Eli Silverman","Yamaha");
            Console.WriteLine(b.Saludo());
            Guitarrista g = new Guitarrista("Slash!", "eléctrica");
            Console.WriteLine(g.Saludo());
            Baterista bat = new Baterista("Nicko McBrain","PDP");
            Console.WriteLine(bat.Saludo());
        }
    }
   
}
