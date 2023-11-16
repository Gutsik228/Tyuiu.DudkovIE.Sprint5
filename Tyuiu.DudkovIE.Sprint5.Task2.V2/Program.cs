using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint5.Task2.V2.Lib;
namespace Tyuiu.DudkovIE.Sprint5.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Дудков И.Е | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:   Класс File. Запись структурированных данных в текстовый файл              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Дудков И.Е  | СМАРТб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с " +
                "клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[,] matrix = new int[3, 3] { {-7, 7, 5 },

                                            { 4, 2, -7 },

                                            { 2, 6 ,-4}
            };
            Console.WriteLine("Матрица");
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл создан: " + res);

            Console.ReadKey();
        }
    }
}
