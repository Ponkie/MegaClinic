using System;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World!";
            Console.WriteLine(hello.ToHash()); ;
        }
    }
}
