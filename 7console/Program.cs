using System;
using System.Linq;

namespace _7console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 1");
                Console.Write("Введите строку: ");
                String str = Console.ReadLine();
                Console.WriteLine("Результат " + GetStringBetweenBrackets(str));

                Console.WriteLine("Задание 2");
                Console.Write("Введите строку: ");
                String str1 = Console.ReadLine();
                Console.Write("Введите количество повторений: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Слова которе повторяются больше " + amount + " раз");
                GetRepeatedWords(str1, amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }

        private static void GetRepeatedWords(string str1, int amount)
        {
            string [] arr = str1.ToLower().Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim('.', ',');
            }
            string [] arr1 = arr.Where(x => arr.Count(z => z == x) > amount).Distinct().ToArray();
            foreach (String item in arr1)
            {
                Console.WriteLine(item);
            }
        }

        private static String GetStringBetweenBrackets(String str)
        {
            if (str.Contains('(') && str.Contains(')'))
            {
                int a = str.IndexOf('(') + 1;
                int b = str.IndexOf(')');
                String result = str.Substring(a, b - a);
                return result;
            }
            else return "круглые скобки отсутствуют";
        }
    }
}
