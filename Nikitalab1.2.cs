using System;
using System.Collections.Generic;

namespace Nikitalab1
{
    public class Program
    {
        // Точка входа в программу
        public static void Main(string[] args)
        {
            // Ввод данных от пользователя
            Console.Write("Введите значение n (количество одинаковых соседних чисел): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество чисел в последовательности: ");
            int size = int.Parse(Console.ReadLine());

            List<int> sequence = new List<int>();

            Console.WriteLine("Введите последовательность чисел:");

            for (int i = 0; i < size; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sequence.Add(number);
            }

            // Вызов метода для проверки последовательности
            var (found, index) = SequenceAnalyzer.CheckForConsecutiveNumbers(n, sequence);

            // Вывод результата
            if (found)
            {
                Console.WriteLine($"Найдена последовательность из {n} одинаковых чисел, начиная с позиции {index}.");
            }
            else
            {
                Console.WriteLine($"Не найдена последовательность из {n} одинаковых чисел.");
            }
        }
    }

    public class SequenceAnalyzer
    {
        public static (bool, int) CheckForConsecutiveNumbers(int n, List<int> sequence)
        {
            if (n <= 1 || sequence == null || sequence.Count < n)
            {
                return (false, -1);  // если n <= 1 или последовательность слишком короткая
            }

            // Проверка на n одинаковых соседних чисел
            for (int i = 0; i <= sequence.Count - n; i++)
            {
                bool isConsecutive = true;
                for (int j = i + 1; j < i + n; j++)
                {
                    if (sequence[j] != sequence[i])
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                if (isConsecutive)
                {
                    return (true, i + 1);  // возвращаем true и порядковый номер первого числа
                }
            }

            return (false, -1);  // если последовательности не найдено
        }
    }
}
