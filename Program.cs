using System;

namespace learn_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}", name);
        }
    }
}
