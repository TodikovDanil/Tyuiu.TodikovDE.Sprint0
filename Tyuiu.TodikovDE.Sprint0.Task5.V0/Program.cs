﻿using Tyuiu.TodikovDE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.TodikovDE.Sprint0.Task5.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Multiplication(10,10));
            Console.WriteLine(DataService.Subtraction(15,5));
            Console.WriteLine(DataService.Division(25,5));
            Console.ReadKey();
        }
    }
}