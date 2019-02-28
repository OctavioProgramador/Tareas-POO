using System;

namespace tarea2
{
    class Dado{
        private int valor;
        private string color;
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
        public Dado(string color){
            this.Color = color;
            Random r = new Random();
            Valor  = r.Next(1,6);
        } 
        public Dado(string color, int valor){
            this.Color = color;
            this.Valor  = valor;
        } 
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

