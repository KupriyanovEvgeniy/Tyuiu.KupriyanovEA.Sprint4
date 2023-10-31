using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KupriyanovEA.Sprint4.Task1.V1.Lib;

namespace Tyuiu.KupriyanovEA.Sprint4.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил Куприянов Е. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Куприянов Евгений Александрович | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, Дан одномерный целочисленный массив на 10     *");
            Console.WriteLine("* элементов заполненный значениями с клавиатуры в диапазоне от 0 до 9     *");
            Console.WriteLine("* подсчитать сумму четных элементов массива. С клавиатуры: 8, 2, 7, 5, 0, *");
            Console.WriteLine("* 7, 4, 7, 5, 7                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат сложения чётных элементов: " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
