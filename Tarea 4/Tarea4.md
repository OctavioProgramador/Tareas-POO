# Tarea 4
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

(1) Imprime 10 que es el valor de a y (2) imprime el valor de 10 ya que está llamando al Dibuja de A.

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

#### 2. Considera el siguiente fragmento de programa:

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
    Musico [] m = ____________________
    m[0] = b;
    m[1] = g; 
    foreach ( ___________)
       _____________________
    Console.ReadKey();
 }
}
```
####2.1. Completa el programa.

```csharp
using System;
using System.Collections.Generic;
 abstract class Musico
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
class Bajista: Musico
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
    Musico [] m = ____________________
    m[0] = b;
    m[1] = g; 
    foreach ( ___________)
       _____________________
    Console.ReadKey();
 }
}
```