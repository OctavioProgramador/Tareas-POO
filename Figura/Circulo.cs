using System;

namespace Figura
{
    class Circulo:Figura
    {
        //Atributos
        private int radio;

        //Constructores
        public Circulo(Color relleno, Color borde,int radio, Vector2D posicion):base(relleno,borde,posicion)
        {
            this.radio= radio;
        }
        public Circulo(Color relleno, Color borde,int radio, int x, int y):base(relleno,borde,x,y)
        {
            this.radio= radio;
        }
        //Métodos
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un círculo en la posición {0} de un color con código {1}", posicion.ToString(),relleno.ToString() );
        }
        public override double Area()
        {
            return Math.PI*Math.Pow(radio,2);
        }
        public override string Tipo()
        {
            return "círculo";
        }
    }    
}