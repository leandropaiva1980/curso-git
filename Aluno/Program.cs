using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(1, 30, 10);
            t =  t.Multiply(2);
            Console.WriteLine(t);
            
        }
    }
}
