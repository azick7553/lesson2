using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 5;
            // double y = 6.6;
            // decimal d = 5.4m;
            // char c = 'A';
            // string s = "My text";
            // bool b = true;
            // double result = x - y;

            // x = (int)(Math.Round(y));

            double x = 6, y = 3;
            double j = Math.Pow(x, 2);

            double o = Math.Sqrt(j);
            System.Console.WriteLine(j);
            System.Console.WriteLine(o);
            // Console.WriteLine(x - y);
            // Console.WriteLine($"X = {x}, Y = {y}, result={x + y}");
            // Console.WriteLine("X = {0}, Y = {1}, result={2}", x, y, x + y);
            // Console.WriteLine("X = " + x + ", Y = " + y + ", " + "result = " + (x + y));
            Console.Write("Your name:");
            string name = Console.ReadLine();
            Console.Write("Your birth year");
            int birthYear = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Hello, {name}. You are {2020 - birthYear} years old");
        }
    }
}
