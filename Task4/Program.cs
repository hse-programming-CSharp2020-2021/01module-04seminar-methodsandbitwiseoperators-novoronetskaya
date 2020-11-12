using System;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        static uint GetPower(uint n)
        {
            ulong result = 1;
            for(int i = 0; i < n; i++)
            {
                result << 1;
                if (result > Int32.MaxValue)
                {
                    return -1;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            uint n, m;
            if (!uint.TryParse(Console.ReadLine(), out n) || !uint.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Ошибка");
                return;
            }
            int powN = GetPower(n);
            int powM = GetPower(m);
            long sum = powN + powM;
            if (powN < 0 || powM < 0 || sum > Int32.MaxValue)
            {
                Console.WriteLine("Переполнение");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
