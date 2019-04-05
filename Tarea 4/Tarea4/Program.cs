using System;

namespace Tarea4
{
  abstract class Musico
    {
      public string nombre;
      public Musico (string n)
      {
        nombre = n;
      }
      public abstract void Afina();  
      public string Display()
      { 
        return nombre;
      }
    } 
  class Bajista: Musico
  {
    public string instrumento;
    public Bajista (string n, string i ):base(n)
    {
      this.instrumento = i;
    }
    public override void Afina()
    {
      Console.WriteLine("{0} afina el {1}",nombre, instrumento);
    }
 }
class Guitarrista: Musico
     {
      public string instrumento;
      public Guitarrista (string n, string i ):base(n)
      {
        this.instrumento = i;
      }
      public override void Afina()
      {
        Console.WriteLine("{0} afina el {1}",nombre, instrumento);
      }
    }
class Program
 {
  public static void Main()
   {
      //No se puede instanciar una objeto de una clase virtual
      //Musico m = new Musico("Django"); 
      Bajista b = new Bajista("Flea", "bajo acústico");
      Guitarrista g = new Guitarrista("Santana","guitarra Yamaha");
      Musico [] m = new Musico[2];
      m[0] = b;
      m[1] = g; 
      foreach (Musico musico in m)
      {
        musico.Afina();
      }
      Console.ReadKey();
  }
}
}
