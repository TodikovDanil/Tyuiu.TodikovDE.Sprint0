using Tyuiu.TodikovDE.Sprint0.Task7.V0.Lib;
namespace Tyuiu.TodikovDE.Sprint0.Task7.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элемнтов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Умножение элементов массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}