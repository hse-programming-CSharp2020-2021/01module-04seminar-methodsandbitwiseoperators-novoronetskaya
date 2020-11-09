using System;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {

        // TODO: использовать передачу параметров по ссылке
        static void ReadBoundaries(ref uint q, ref uint p, ref bool error)
        {
            error = !uint.TryParse(Console.ReadLine(), out q) || !uint.TryParse(Console.ReadLine(), out p) || p < q;
        }

        static void PrintPythagorasNumbers(uint q, uint p)
        {
            for (uint i = q; i <= p; i++)
            {
                for (uint j = i + 1; j <= p; j++)
                {
                    for (uint k = j + 1; k <= p; k++)
                    {
                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            uint q = 0;
            uint p = 0;
            bool error = false;
            ReadBoundaries(ref q, ref p, ref error);
            if (error)
            {
                Console.WriteLine(p);
                Console.WriteLine(q);
                Console.WriteLine("Ошибка");
                return;
            }
            PrintPythagorasNumbers(q, p);
        }
    }
}