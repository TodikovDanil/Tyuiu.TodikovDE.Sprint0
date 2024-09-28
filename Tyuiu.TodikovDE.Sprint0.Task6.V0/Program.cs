using Tyuiu.TodikovDE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TodikovDE.Sprint0.Task6.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A / B = " + DataService.Division(25, 5));
            Console.ReadKey();
        }
    }
}