using Tyuiu.TodikovDE.Sprint0.Task8.V0.Lib;
namespace Tyuiu.TodikovDE.Sprint0.Task8.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #0                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #0                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Условие:                                                               *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух   *");
            Console.WriteLine("* одинаковых массивов по длине.                                          *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Знчение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length;i++)
            {
                Console.Write(arrayNums1[i] + ",");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Знчение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов Массива ровна: ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ",");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные Массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}