using System;

namespace ex
{
    class EdadIncoirrectaException: Exception
    {
        public EdadIncoirrectaException(string error):base(error){}
        public EdadIncoirrectaException():base("Edad muy grande"){}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captura tu edad:");
            int num = 0;
            string captura;
            try
            {
                captura = Console.ReadLine();
                num = Int32.Parse(captura);
                if(num > 200)throw new EdadIncoirrectaException();
                Console.WriteLine("Se capturó el número {0} correctamente ", num);
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            //Siempre debe ir hasta al final la general        
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Siempre");
            }
        }
    }
}
