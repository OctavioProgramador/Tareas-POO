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
}