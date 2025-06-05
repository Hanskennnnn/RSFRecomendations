using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalimulin_DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void Task1()
        {
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; 
            }
            Console.WriteLine("Введите числа которые нужно поменять местами(каждую на отдельной строке): ");
            while(!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("Ошибка ввода.Введите правильное число из массива.");
            }



        }
    }
}
