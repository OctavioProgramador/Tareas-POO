# Unidad 3 Herencia.

## Instituto Tecnológico de Tijuana

Alumno: Salasar Ramírez Octavio

Número de control: 18212265

___

### Tarea 3

___

## 3.- Herencia

**La clase base y la clase derivada.** La herencia es una propiedad esencial de la Programación Orientada a Objetos que consiste en la creación de nuevas clases a partir de otras ya existentes. Este término ha sido prestado de la Biología donde afirmamos que un niño tiene la cara de su padre, que ha heredado ciertas facetas físicas o del comportamiento de sus progenitores.

La herencia es la característica fundamental que distingue un lenguaje orientado a objetos la cual permite heredar a las clases características y conductas de una o varias clases denominadas base. Las clases que heredan de clases base se denominan derivadas, estas a su vez pueden ser clases bases para otras clases derivadas. Se establece así una clasificación jerárquica, similar a la existente en Biología con los animales y las plantas.

## Digrama de clase de figuras

![DiagramaDeClase](Diagrama.png)

**Las clase base** en este caso en la clase abstracta Figura, que se relaciona por medio de herencia con las **clases derivadas** Triangulo y Rectangulo.

## Herencia simple y multiple

Hay dos tipos de herencia: Herencia Simple y Herencia Múltiple. La primera indica que se pueden definir nuevas clases solamente a partir de una clase inicial mientras que la segunda indica que se pueden definir nuevas clases a partir de dos o más clases iniciales. En c# no se permite herecia múltiple, en su lugar se puede optar por usar *interfaces.*

*Fuente:*

><http://p-o-o-itsav.blogspot.com/2012/02/32-clasificacion-herencia-simple-y.html>

## Programa Figura

**Proyecto adjunto en la carpeta figura de este repositorio.**

```csharp
using System;

namespace Figura
{
    class Vector2D
    {
        //Propiedades
        public int X{get; set;}
        public int Y{get; set;}
        //Constructor
        public Vector2D()
        {
            X=0;Y=0;
        }
        public Vector2D(int x, int y)
        {
            X = x;Y=y;
        }
        //Metodo
        public override string ToString()
        {
            return string.Format("({0}, {1})",X,Y);
        }
    }

    class Color
    {
        //Atributos
        private int r;
        private int g;
        private int b;
        //Propiedades
        public int R
        {
            get{return r;} 
            set{r= AsignarValorColor(value);}
        }
        public int G
        {
            get{return g;} 
            set{g= AsignarValorColor(value);}
        }
        public int B
        {
            get{return b;} 
            set{b= AsignarValorColor(value);}
        }
        //Constructor
        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        //Métodos
        public override string ToString()
        {
            return string.Format("R: {0}, G: {1}, B:{2}",R,G,B);
        }
        private int AsignarValorColor(int color)
        {
            if (color>255)
            {
                return 255;
            }
            else if (color< 0)
            {
                return 0; 
            }
            else 
            {
                return color;
            }
        }   
    }

    abstract class Figura
    {
        //Atributos
        protected Vector2D posicion;
        protected Color relleno;
        protected Color borde;
        //Constructor 
        public Figura(Color relleno, Color borde, Vector2D posicion)
        {
            this.relleno = relleno;
            this.borde = borde;
            this.posicion = posicion;
        }
        public Figura(Color relleno, Color borde, int x, int y)
        {
            this.relleno = relleno;
            this.borde = borde;
            posicion = new Vector2D(x,y);
        }
        //Métodos
        public abstract void Dibuja();
        public abstract double Area();
        public abstract string Tipo();
    }

    class Triangulo: Figura
    {
        //Atributos
        private int altura;
        private int ancho;
        //Constructor
        public Triangulo(Color relleno, Color borde,int altura, int ancho, Vector2D posicion):base(relleno,borde,posicion)
        {
            this.altura= altura;
            this.ancho = ancho;
        }
        public Triangulo(Color relleno, Color borde,int altura, int ancho, int x, int y):base(relleno,borde,x,y)
        {
            this.altura= altura;
            this.ancho = ancho;
        }
        //Métodos
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un triángulo en la posición {0} de un color con código {1}", posicion.ToString(),relleno.ToString() );
        }
        public override double Area()
        {
            return ancho*altura/2;
        }
        public override string Tipo()
        {
            return "triángulo";
        }
    }

    class Rectangulo:Figura
    {
        //Atributos
        private int altura;
        private int ancho;
        //Constructores
        public Rectangulo(Color relleno, Color borde,int altura, int ancho, Vector2D posicion):base(relleno,borde,posicion)
        {
            this.altura= altura;
            this.ancho = ancho;
        }
        public Rectangulo(Color relleno, Color borde,int altura, int ancho, int x, int y):base(relleno,borde,x,y)
        {
            this.altura= altura;
            this.ancho = ancho;
        }
        //Métodos
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un rectángulo en la posición {0} de un color con código {1}", posicion.ToString(),relleno.ToString() );
        }
        public override double Area()
        {
            return ancho*altura;
        }
        public override string Tipo()
        {
            return "rectángulo";
        }
    }

    class Pentagono:Figura
    {
        private double lado;
        private double apotema;
        public Pentagono(Color relleno, Color borde,double lado, double apotema, Vector2D posicion):base(relleno,borde,posicion)
        {
            this.lado= lado;
            this.apotema = apotema;
        }
        public Pentagono(Color relleno, Color borde,double lado, double apotema, int x, int y):base(relleno,borde,x,y)
        {
            this.lado = lado;
            this.apotema = apotema;
        }
        //Métodos
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un pentágono en la posición {0} de un color con código {1}", posicion.ToString(),relleno.ToString() );
        }
        public override double Area()
        {
            return ((lado*apotema)/2)*5;
        }
        public override string Tipo()
        {
            return "pentágono";
        }
}
```

## La palabra clave base

La palabra clave *base* es usada para acceder miembros de la clase base(clase padre) desde una clase dereivada.
>Se puede llamar a un método en la clase base que halla sido sobrescrito por otro método.
>Especifica cual costructor de la clase base puede ser llamado cuando se crean instancias de la clase derivada
