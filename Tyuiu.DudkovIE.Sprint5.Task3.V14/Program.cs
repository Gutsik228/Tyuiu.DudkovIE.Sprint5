using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint5.Task3.V14.Lib;
namespace Tyuiu.DudkovIE.Sprint5.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Дудков И.Е | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Потоковый метод записи данных в бинарный файл                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Дудков И.Е  | СМАРТб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* ДДано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль." +
                " Округлить до трёх знаков после запятой.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int x = 3;
            Console.WriteLine("x: " + x);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл создан: " + res);

            Console.ReadKey();
        }
    }
}
