using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Musico m = new Musico("Lady Gaga");
            //Console.WriteLine(m.Saludo());
            m.Imprimir();
            Bajista b = new Bajista("Eli Silverman","Yamaha");
            b.Imprimir();
            Guitarrista g = new Guitarrista("Slash!", "eléctrica");
            g.Imprimir();
            Baterista bat = new Baterista("Nicko McBrain","PDP");
            bat.Imprimir();
        }
    }
   
}
