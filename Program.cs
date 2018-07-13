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

        // Passing by reference
        void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        // Passing by output
        static void GetValues(out int x, out int y)
        {
            x = 8;
            y = 24;
        }
        static void TestGetValues(string[] args)
        {
            int a, b;
            GetValues(out a, out b);
            // Now a equals 8, b equals 24
        }
    }
}