# Unidad 2. Clases y Objetos

## Instituto tecnológico de Tijuana

Alumno: Salasar Ramírez Octavio

Número de control: 18212265
___

### Tarea 2

___

#### *2.1 Declaración de clases: atributos, métodos, encapsulamiento.*

##### **Clases y estructuras**

Las clases y estructuras son estructuras de datos que encapsulan un conjunto de datos y comportamientos, llamados miembros los cuales son métodos, propiedades, eventos, entre otros. La declaración de clases o estructuras nos sirven como molde para crear instancias u objetos. Las clases son un tipo de referencia ya que cuando se crea el objeto de la clase, la variable a la que se a asigna sólo contiene la referencia de la memoria, en cambio cuando se crea una estructura, la variable en la que se asigna contiene toda la estructura. Las clases se usan para modelar comportamientos más complejos y las estructuras se crean para estructuras de datos que nos se prevén modificar después.

##### **Encapsulamiento**

El encampsulamiento es el primer pilar de la programación orientada a objetos. El principio de encapsulamiento establece que una clase puede especificar que tan disponibles al exterior pueden estar sus atributos. Los métodos y variables que no estén destinados a ser usados fuera de la clase o estructura pueden ser ocultados para evitar errores de código o comportamientos maliciosos.

_Fuente:_

><http://msdn.microsoft.com/es-es/library/ms173109.aspx>

#### *2.2 Instanciación de una clase.*

El operador new se usa para instanciar objetos e invocar constructores, por ejemplo

````c#
Class Ejemplo
{
    private string cadena;
    public Ejemplo(){
        cadena="";
    }
}

Class program
{
    static void Main()
    {
        Ejemplo clase1 = new Ejemplo();
    }
}
````

#### *2.3 Referencia al objeto actual.*

**Programa 1:**

````c#
using.System;
namespace tarea2
{
    class Cuadrilatero
    {
        private int ancho;
        private int largo;
        public Cuadrilatero(int ancho, int largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
    }
}
````

**Programa 2:**

````c#
using.System;
namespace tarea2
{
    class Cuadrilatero
    {
        private int ancho;
        private int largo;
        public Cuadrilatero(int ancho, int largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
        public int Ancho
        {
            get{return ancho;}
            set{ancho = value;}
        }
        public int Largo
        {
            get{return largo;}
            set{largo = value;}
        }
        public void Imprimir()
        {
            Console.WriteLine(Area.CalcularArea(this));
        }
    }
    class Area
    {
        public static double CalcularArea(Cuadrilatero C)
        {
            return C.Ancho*C.Largo;
        }
    }
class Program {
    static void Main()
    {
        Cuadrilatero a = new Cuadrilatero(2,2);
        a.Imprimir();
    }
}
}

````

#### **2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.**

Los parámetros declarados para un método sin in, ref o out se pasan al método llamado por valor. Si usa palabras clave de parámetros de método en la declaración del parámetro, puede modificar este comportamiento.

**Params:** Se puede usar dentro de los parámetros para indicar que se pueden pasar un número cualquiera de parámetros al método, y el método los recivirá como un vector o matriz unidimensional. Por ejemplo:

```csharp
using.System;
namespace params
{
    class Ejemplo
    {
        public static void ImprimirTodo(params string[] palabras )
        {
            foreach(string x in palabras)
            {
                Console.WriteLine(x);
            }
        }
    }
    class Program 
    {
        static void Main()
        {
            Ejemplo.ImprimirTodo("Peras","manzanas","ajo");
            /*Deberá imprimir:
                Peras
                Manzanas
                Ajo
            */
        }
    }
}
```

**Ref:** La palabra clave ref sirve para indicar que vamos a hacer un pase de paramatros por referencia en vez de pasar parámetros por su valor. Ejemplo:

````c#
using.System;
namespace ejemplo
{
    class Ejemplo
    {
        public static void ModificarInt(ref int valor )
        {  
            valor = valor +1;
        }
    }
    class Program
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine(a);
            Ejemplo.ModificarInt(ref a);
            Console.WriteLine(a);
            /*Se deberá imprimir:
            1
            2
            */
        }
    }
}
````

**In:** La palabra clave in hace que los argumentos pasen como referncia, pero no se pueden modificar en el método;

**Out:** La palabra clave out sirve para pasar argumentos a un método com referencia, sólo que estos no tienen que tener un valor asignado, su valor se va a asignar en el método al cual son pasados como referencia.

#### **2.5 Constructores y destructores: declaración, uso y aplicaciones.**

Un constructor es un método que nos sirve para inicializar o instanciar los objetos de una clase. Debe ser un método public con el mismo nombre de la clase, y debe de inicializa los valores de la clase, además no debe manejar ningún valore de retorno, ni siquiera void. Ejemplo:

```c#
using.System;
namespace ejemploConstructor
{
    class Ejemplo
    {
        private int valor1;
        private int valor2;
        //Constructor. Mismo nombre de la clase.
        //inicializa los valores (si se desea), no retorna valores.
        public Ejemplo(int a, int b){
            valor1 = a;
            valor2 = b;
        }
    }
    class Program
    {
        static void Main()
        {
            //Aquí se invoca al constructor para inicializar el objeto
            Ejemplo ejemplo1 = new Ejemplo(1,2);
        }
    }
}
```

#### **2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.**

```c#
using System;

namespace tarea2
{
    class Dado{
        //Atributos
        private int valor;
        private string color;

        //Propiedades
        public int Valor
        {
            get {return valor;}
            set
            {
                if (value>6)
                {
                    valor = 6;
                }
                else if (value<1)
                {
                    valor = 1;
                }
                else
                {
                    valor = value;
                } 
            }
        }
        public string Color{
            get {return color;}
            set {color = value;}
        }

        //Constructores
        public Dado(string color){
            this.Color = color;
            Random r = new Random();
            Valor  = r.Next(1,6);
        }
        public Dado(string color, int valor){
            this.Color = color;
            this.Valor  = valor;
        }

        //Operadores sobrecargados
        public static bool operator < (Dado a, Dado b){
            return (a.Valor<b.Valor);
        }
        public static bool operator > (Dado a, Dado b){
            return (a.Valor>b.Valor);
        }
        public static bool operator == (Dado a, Dado b){
            return (a.Valor==b.Valor);
        }
        public static bool operator != (Dado a, Dado b){
            return (a.Valor!=b.Valor);
        }

        //Método de comparación
        public static void Comparar(Dado a, Dado b, Dado c){
            Console.WriteLine("Dado a, color: {0}, valor: {1}",a.Color, a.Valor);
            Console.WriteLine("Dado b, color: {0}, valor: {1}",b.Color, b.Valor);
            Console.WriteLine("Dado c, color: {0}, valor: {1}",c.Color, c.Valor);
            if ((a>b)&&(a>c))
            {
                Console.WriteLine("El dado mayor es el de color: {0} con valor: {1}",a.Color, a.Valor);
            }
            else if ((b>c)&&(b>a))
            {
                Console.WriteLine("El dado mayor es el de color: {0} con valor: {1}",b.Color, b.Valor);
            }
            else if ((c>a)&&(c>b))
            {
                Console.WriteLine("El dado mayor es el de color: {0} con valor: {1}",c.Color, c.Valor);
            }
            else if ((c==a)&&(c>b))
            {
                Console.WriteLine("Los dados de color: {0},con valor: {1} y color: {2}, con valor: {3}",c.Color, c.Valor, a.Color, a.Valor);
            }
            else if ((c==b)&&(c>a))
            {
                Console.WriteLine("Los dados de color: {0},con valor: {1} y color: {2}, con valor: {3}",c.Color, c.Valor, b.Color, b.Valor);
            }
            else if ((a==b)&&(a>c))
            {
                Console.WriteLine("Los dados de color: {0},con valor: {1} y color: {2}, con valor: {3}",a.Color, a.Valor, b.Color, b.Valor);
            }
            else {
                Console.WriteLine("Los tres dados son iguales");

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dado a = new Dado("rojo", 5);
            Dado b = new Dado("verde", 5);
            Dado c = new Dado("azul", 3);
            Dado.Comparar(a,b,c);

        }
    }
}

```