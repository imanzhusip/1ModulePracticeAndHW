using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("Введите Ф.И.О");
            String FullName = Console.ReadLine();
            Console.WriteLine("Приветствую тебя {0}", FullName);
        }

        static void task2()
        {
            Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();
            double number1;

            if (double.TryParse(input1, out number1))
            {
                Console.WriteLine("Введите второе число");
                string input2 = Console.ReadLine();
                double number2;
                if (double.TryParse(input2, out number2))
                {
                    double sum = number1 + number2;
                    Console.WriteLine("Сумма чисел: {0}", sum);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода второго числа");
                }
            }
            else
            {
                Console.WriteLine("Ошмбка ввода первого числа");
            }

        }
        static void Main(string[] args)
        {
            task2();
            Console.ReadKey();
        }
    }
}

