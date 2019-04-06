# Unidad 4 Polimorfismo.

## Instituto Tecnológico de Tijuana

Alumno: Salasar Ramírez Octavio

Número de control: 18212265

___

### Tarea 4

___

## 1. Considera el siguiente fragmento de programa:

```csharp
using System;

class A
  {
    public int a;
    public A()
      {
        a = 10;
      }
    public _______ string Display()
    {
      return a.ToString();
    }
  }
class B:A
  {
   public int b;
   public B():base()
   {
    b = 15;
   }
  // #########################################

  //  #  Después de contestar la pregunta 1                  

 //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.

 //  #########################################
}
class Program
  {
   public static void Main()
    {
      A objA = new A();
      B objB = new B();
      Console.WriteLine(objA.Display()); ////  (1 )
      Console. WriteLine(objB.Display()); ////  ( 2)
    }
  }
```

### 1.1. ¿Qué valores imprimen las lineas (1) y (2)?

(1) Imprime 10 que es el valor de a y (2) imprime el valor de 10 ya que está llamando al Display de A.

### 1.2.  Redefine el método Display en el espacio indicado,  una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?.

(1) Imprime 10 que es el valor de a y (2) imprime el valor de 15 ya que está llamando al Dibuja de B.


```csharp
using System;

class A
  {
    public int a;
    public A()
      {
        a = 10;
      }
    public virtual string Display()
    {
      return a.ToString();
    }
  }
class B:A
  {
   public int b;
   public B():base()
   {
    b = 15;
   }
    public override string Display()
    {
      return b.ToString();
    } 
}
class Program
  {
   public static void Main()
    {
      A objA = new A();
      B objB = new B();
      Console.WriteLine(objA.Display()); ////  (1 )
      Console. WriteLine(objB.Display()); ////  ( 2)
    }
  }
```

### 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?

**Virtual**

## 2. Considera el siguiente fragmento de programa:

```csharp
using System;
using System.Collections.Generic;
 ________ class Musico
  {
    public string nombre;
    public Musico (string n)
      {
        nombre = n;
      }
   public abstract (A) void Afina();  (B)
   public (C) string Display()
    { 
      return nombre;
    }
  }
class Bajista; Musico
  {
    public string instrumento;
    public Bajista (string n, string i ) ......
    .........
    public _________ Afina()
      {
      ________________
      }
 }
class Guitarrista ____________
     {
     public instrumento;
      // Falta el constructor y otras cosas??
     }
class Program
 {
  public static Main()
   {
    Musico m = new Musico("Django"); (D)
    Bajista b = new Bajista("Flea");
    Guitarrista g = new Guitarrista("Santana");
    List<Musico> musicos = ____________________
    musicos.Add(b);
    musicos.Add(g);
    foreach ( _____in musicos______)
        ____________________

 // (m as IAfina).Afina()
       _____________________
    Console.ReadKey();
 }
}
```

### 2.1. Completa el programa.

```csharp
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
      List<Musico> musicos = new List<Musico>();
      musicos.Add(b);
      musicos.Add(g);
      foreach (Musico musico in musicos)
      {
        Console.WriteLine(musico.Afina());
        musico.Afina();
      }
      Console.ReadKey();
  }
}
```

### 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?

El error ocurre en (D) por que cuando se le pone la keyword abstract en la clase, no se pueden crear objetos o instancias de esa clase;

### 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?

El método Afina(), ya que como tiene el keyword abstract en su implementación en la clase Musico todas las clases derivadas deben de implementar los métodos con la keyword abstract.

### 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?

Por que la en las sintaxis del los métodos abstractos no se pide usar llaves, ya que por definición no tienen implementación en la clase que se crean. Se pondrían en todos los otros casos que se declare un método no abstracto, o lleverían en la implementación de una clase derivada de estas.

### 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?

Tendriamos que, primero que nada cambiar la palabra clave abstract por virtual, luego, asignarle una implementación, que podrían ser mínimo unas llaves vacias, o con un bloque de código, además de recordar quitar el punto y coma.

## 3. Implementa el programa utilizando interfaces en lugar de herencia

```csharp
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
```