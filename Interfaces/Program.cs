using System;
using System.Collections.Generic;

namespace Interfaces
{
    interface IRenderizable
    {   
        void Render();
    }
    class Image : IRenderizable
    {
        public void Render()
        {
            Console.WriteLine("The image is rendering");
        }
    }
    class Video : IRenderizable
    {
        public void Render()
        {
            Console.WriteLine("The video is rendering");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> lista = new List<string>();
            Dictionary<string,IRenderizable> d = new Dictionary<string, IRenderizable>();
            d.Add("intro.mov",new Video());
            d.Add("Pedro01.png",new Image());
            d.Add("ending.mov",new Video());
            d.Add("example02.png",new Image());
            d.Add("presentation.mov",new Video());
            IRenderizable contenido;
            Console.WriteLine(d.TryGetValue("Pedro01.png",out contenido));
            Console.WriteLine(contenido.ToString());
        }
    }
}
