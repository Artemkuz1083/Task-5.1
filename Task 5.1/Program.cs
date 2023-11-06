using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeWork1();
        }

        public static void HomeWork1()
        {
            Console.WriteLine("Задание 5.1\nЧтобы завершить программу введите q");
            List<float> numbers = new List<float>();
            while (true)
            {
                Console.Write("Введите число: ");
                string str = Console.ReadLine();
                if (str == "q" || str.Length == 0)
                {
                    break;
                }

                if (int.TryParse(str, out int intNumber))
                {
                    Console.WriteLine(intNumber);
                    numbers.Add(intNumber);
                }
                else if (float.TryParse(str, out float floatNumber))
                {
                    if (numbers.Last() == floatNumber)
                        break;
                    numbers.Add(floatNumber);
                }
                else
                {
                    Console.WriteLine("Число введено не корректно");
                }
            }
        }
    }
}
