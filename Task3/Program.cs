using System;

/*
 * На вход подаются три числа: параметры функции a, b, c
 * Протабулировать функцию y на x \in [1;2] с шагом ∆𝑥 = 0,05
 *
 *      ax^2 + bx + c,              x < 1,2
 * y =  a/x + sqrt(x^2 + 1),        x = 1,2
 *      (a + bx) / sqrt(x^2 + 1),   x > 1,2
 *
 * Пример входных данных:
 * 1
 * 2
 * 3
 *
 * Пример выходных данных:
 * 6
 * 6,203
 * 6,41
 * 6,623
 * 2,395
 * 2,186
 * 2,195
 * 2,202
 * 2,209
 * 2,214
 * 2,219
 * 2,223
 * 2,226
 * 2,229
 * 2,231
 * 2,233
 * 2,234
 * 2,235
 * 2,236
 * 2,236
 * 2,236
 *
 * Примечание: 
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Вывод чисел необходимо производить с точностью до трех знаков после запятой.
 */

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double a = GetValidData();
            double b = GetValidData();
            double c = GetValidData();
            GetEquations(a, b, c, ref x);
        }
        static double GetValidData()
        {
            return double.Parse(Console.ReadLine());
        }
        static void GetEquations(double a, double b, double c, ref double x)
        {
            double result;
            while (x < 1.2)
            {
                result = a * x * x + b * x + c;
                Console.WriteLine($"{result:f3}");
                x += 0.05;
            }
            result = a / x + Math.Sqrt(x * x + 1);
            Console.WriteLine($"{result:f3}");
            x += 0.05;
            while (x < 2.05)
            {
                result = (a + b * x) / Math.Sqrt(x * x + 1);
                Console.WriteLine($"{result:f3}");
                x += 0.05;
            }
        }
    }
}