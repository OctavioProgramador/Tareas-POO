using System;

namespace Figura
{
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
}