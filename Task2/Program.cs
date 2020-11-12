using System;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        // TODO: используйте передачу параметров по ссылке
        static void ReadData()
        {
            long sum = 0;
            string input = Console.ReadLine();
            long x = 0;
            int num = 0;
            while (sum >= -1000 && input != "q")
            {
                if (!long.TryParse(input, out x) && input != "q" || x > Int32.MaxValue)
                {
                    Console.WriteLine(input);
                    Console.WriteLine("Ошибка");
                    return;
                }
                if (x < 0)
                {
                    sum += x;
                    num++;
                }
                input = Console.ReadLine();
            }
            if (num == 0) 
            {
                return;
            }
            double average = (double)sum / num;
            Console.WriteLine(GetOutputFormat($"{average:f2}"));
        }
        static string GetOutputFormat(string answer)
        {
            int index = answer.Length - 1;
            while (answer[index] == '0')
            {
                answer = answer.Substring(0, index);
                index = answer.Length - 1;
            }
            if (answer[index] == '.')
            {
                answer = answer.Substring(0, index);
            }
            return answer;
        }
        static void Main()
        {
            ReadData();
        }
    }
}
