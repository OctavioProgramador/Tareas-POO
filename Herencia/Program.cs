using System;
using System.Collections.Generic;
namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vocalista m = new Vocalista("Lady Gaga");
            //Console.WriteLine(m.Saludo());
            //m.Imprimir();
            Bajista b = new Bajista("Eli Silverman","Yamaha");
            //b.Imprimir();
            Guitarrista g = new Guitarrista("Slash!", "eléctrica");
            //g.Imprimir();
            Baterista bat = new Baterista("Nicko McBrain","PDP");
            //bat.Imprimir();
            List<Musico> musicos = new List<Musico>();
            musicos.Add(m);
            musicos.Add(b);
            musicos.Add(g);
            musicos.Add(bat);
            foreach (Musico x in musicos)
            {
                Console.WriteLine(x.Saludo());
            }
        }
    }
   
}
