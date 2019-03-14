using System;

namespace Figura
{
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
}