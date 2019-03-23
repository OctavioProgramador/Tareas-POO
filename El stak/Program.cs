using System;
public class Stack<T>

{
   readonly int m_Size; 
   int m_StackPointer = 0;
   T[] m_Items;
   public Stack():this(100)
   {}
   public Stack(int size)
   {
      m_Size = size;
      m_Items = new T[m_Size];
   }
   public void Push(T item)
   {
      if(m_StackPointer >= m_Size) 
         throw new StackOverflowException();
      m_Items[m_StackPointer] = item;
      m_StackPointer++;
   }
   public T Pop()
   {
      m_StackPointer--;
      if(m_StackPointer >= 0)
      {
         return m_Items[m_StackPointer];
      }
      else
      {
        m_StackPointer = 0;
        throw new InvalidOperationException("Cannot pop an empty stack");
      }
   }
}

namespace El_stak
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pila = new Stack<string>();
            pila.Push("Ana");
            pila.Push("Tom");           
            pila.Push("Sue");
            for(int i = 0; i<3; i++)
            System.Console.WriteLine(pila.Pop());
        }
    }
}
