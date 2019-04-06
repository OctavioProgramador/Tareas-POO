using System;
using System.Collections.Generic;

namespace Tarea4
{
  interface IAfinable
  {
    void Afina();  
  }
  abstract class Musico
    {
      public string nombre;
      public Musico (string n)
      {
        nombre = n;
      }
      public string Display()
      { 
        return nombre;
      }
    } 
  class Bajista: Musico, IAfinable
  {
    public string instrumento;
    public Bajista (string n, string i ):base(n)
    {
      this.instrumento = i;
    }
    public void Afina()
    {
      Console.WriteLine("{0} afina el {1}",nombre, instrumento);
    }
 }
class Guitarrista: Musico, IAfinable
     {
      public string instrumento;
      public Guitarrista (string n, string i ):base(n)
      {
        this.instrumento = i;
      }
      public void Afina()
      {
        Console.WriteLine("{0} afina la {1}",nombre, instrumento);
      }
    }
class Program
 {
  public static void Main()
   {
      Bajista b = new Bajista("Flea", "bajo acústico");
      Guitarrista g = new Guitarrista("Santana","guitarra Yamaha");
      List<Musico> musicos = new List<Musico>();
      musicos.Add(b);
      musicos.Add(g);
      foreach (Musico musico in musicos)
      {
        System.Console.WriteLine(musico.Display());
        (musico as IAfinable).Afina();
      }
      Console.ReadKey();
  }
}
}
