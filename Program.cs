﻿using System;

namespace learn_csharp
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}", name);
        }

        // Passing by reference
        void Swap(ref int x, ref int y) {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        // Passing by output
        static void GetValues(out int x, out int y) {
            x = 8;
            y = 24;
        }
        static void TestGetValues(string[] args)
        {
            int a, b;
            GetValues(out a, out b);
            // Now a equals 8, b equals 24
        }

        // Overloading Methods
        static void Print(int a) {
            Console.WriteLine(a);
        }
        static void Print(double a) {
            Console.WriteLine(a);
        }
        static void Print(string label, double a) {
            Console.WriteLine(label + a);
        }

        // Encapsulation - hide details of class
        // access modifiers: public, private, protected, protected internal.
        class BankAccount {
            private double balance = 0;
            public void Deposit(double n) {
                balance += n;
            }
        }

    }
}