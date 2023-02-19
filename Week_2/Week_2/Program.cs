using System;
using Week_2;

namespace Week_2
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Stack<int> result = new Stack<int>();
            result.Push(1);
            result.Push(2);
            result.Push(3);
            result.Push(4);
            result.Push(5);
            foreach(var i in result)
            {
            Console.WriteLine(i);
            }
          
            Queue<int> Result2 = new Queue<int>();
            Result2.Enqueue(1);
            Result2.Enqueue(2);
            Result2.Enqueue(3);
            Result2.Enqueue(4);
            Result2.Enqueue(5);
            foreach (var i in Result2)
            {
                Console.Write(i);
            }
           
        }
    }
}
