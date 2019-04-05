using System;

namespace Figura
{
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
}