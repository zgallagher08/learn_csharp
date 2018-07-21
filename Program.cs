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

        // Constructors - must have the same name as the class

        // Properties
        class Person {
            private string name;

            public string Name {
                get { return name; }
                set { name = value; }
            }
        }

        // Auto-implemented Properties
        class Person2 {
            public string Name { get; set; }
        }

        // Arrays
        void Arrays() {

            int[] myArray = new int[8];
            int[] myArray2 = { 2, 3, 5, 6 };

            // Arrays in loops
            foreach (int val in myArray) {
                Console.WriteLine(val);
            }

            // Multidimensional Arrays
            double[,] mdArr = new double[3, 4];

            // Array properties
            Console.WriteLine(myArray2.Length); // 4
            Console.WriteLine(myArray2.Rank); // 2
            Console.WriteLine(myArray2.Max()); // 2
            Console.WriteLine(myArray2.Min()); // 6
            Console.WriteLine(myArray2.Sum()); // 16
        }

        // Destructors
        class Dog {
            ~Dog() {
               // invoked automatically when an object is destroyed or deleted 
            }
        }

        // Static Classes
        //
        // Math.PI
        // Math.E
        //
        // Array.Reverse(arr)
        // Array.Sort(arr)
        //
        // String.Concat(s1, s2)
        // String.Equals(s1, s2)
        //
        // DateTime.Now
        // DateTime.Today

        // Operator Overloading
        class Box {
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w) {
                Height = h;
                Width = w;
            }
        }
        public static Box operator+(Box a, Box b) {
            int h = a.Height + b.Height;
            int w = a.Width + b.Width;
            Box result = new Box(h, w);
            return result;
        }
        // Box b3 = b1 + b2;

        // Inheritance
        class Animal {
            public int Legs { get; set; }
            public int Age { get; set; }

            // protected access modifier
            // very similar to private, but it can be accessed in
            // the derived classes.
            protected string Name { get; set; }
        }
        class Dog : Animal {
            public Dog(string name) {
                Legs = 4;
                Name = name;
            }
            public void Bark() {
                Console.Write('Woof');
            }
        }
    }
}