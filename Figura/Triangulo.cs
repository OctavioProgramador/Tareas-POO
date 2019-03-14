using System;

namespace Figura
{
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
}