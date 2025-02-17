namespace Nikitalab1
{
    using System;

    public class Converter
    {
        // Метод для склонения слова "рубль"
        private static string GetRublesWord(int rubles)
        {
            if (rubles % 10 == 1 && rubles % 100 != 11)
                return "рубль";
            else if (rubles % 10 >= 2 && rubles % 10 <= 4 && (rubles % 100 < 10 || rubles % 100 >= 20))
                return "рубля";
            else
                return "рублей";
        }

        // Метод для склонения слова "копейка"
        private static string GetKopecksWord(int kopecks)
        {
            if (kopecks % 10 == 1 && kopecks % 100 != 11)
                return "копейка";
            else if (kopecks % 10 >= 2 && kopecks % 10 <= 4 && (kopecks % 100 < 10 || kopecks % 100 >= 20))
                return "копейки";
            else
                return "копеек";
        }

        public static string ConvertCost(int n)
        {
            int rubles = n / 100; // целые рубли
            int kopecks = n % 100; // оставшиеся копейки

            string rublesWord = GetRublesWord(rubles);
            string kopecksWord = GetKopecksWord(kopecks);

            if (rubles > 0 && kopecks > 0)
            {
                return $"{rubles} {rublesWord} {kopecks} {kopecksWord}";
            }
            else if (rubles > 0 && kopecks == 0)
            {
                return $"{rubles} {rublesWord}";
            }
            else if (rubles == 0 && kopecks > 0)
            {
                return $"{kopecks} {kopecksWord}";
            }
            else
            {
                return "0 рублей";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите стоимость товара в копейках: ");
            int n = int.Parse(Console.ReadLine());
            string result = Converter.ConvertCost(n);
            Console.WriteLine(result);
        }
    }
}
