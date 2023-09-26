using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите операцию (+, -, *, /,^,%):");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("деление на ноль");
                            return;
                        }
                        break;
                    case '^':
                        result = num1 * num1;
                        break;
                    case '%':
                        result = num1 % num1;
                        break;

                    default:
                        Console.WriteLine("неверная операция");
                        return;
                }

                Console.WriteLine("Результат: " + result);
            }
        }
    }
}

