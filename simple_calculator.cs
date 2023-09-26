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
            int first_num; // нарушение правил именования. Смотрите нотации в лекции или на образовательном портале. Следовало дать такое имя firstNum
            int second_num; // нарушение правил именования. Смотрите нотации в лекции или на образовательном портале.
            char operation;
        // метод Main () не должен содержать функционал, в нем следует только вызывать нужные Вам методы.
            // объявление переменных, используемых по всему коду нужно делать на уровне класса, а не метода
        static void Main(string[] args)
        {
            SelectOperation(); // создали метод по выбору мат операции, и тут его только вызываем
            Calc () 
            Console.ReadKey();       
        }
        static void Calc ()
        {
               // для перебора операций лучше использовать switch case
            // в каждом блоке if у вас дублируется один и тот же код, это нарушает один из принципов ООП (принцип DRY). Следует выносить это в отдельный метод и в нужном месте кода его вызывать. Например метод GetNums()
            if (operation == '+')
            {
                GetNums();
                Console.WriteLine("Ðåçóëüòàò:" + (first_num + second_num));
           }

            else if (operation == '-')
            {
                 GetNums();
                Console.WriteLine("Ðåçóëüòàò: " + (first_num - second_num));
                
            }

            else if (operation == '*')
            {
                 GetNums();
                Console.WriteLine("Ðåçóëüòàò: " + (first_num * second_num));
                

            }

            else if (operation == '/') // следовало добавить обработку исключения на случай, если второе число = 0
            {
                GetNums();

                Console.WriteLine("Ðåçóëüòàò: " + (first_num / second_num));
                
            }

            else if (operation == "^")
            {
                int num1ques;
               // тоже вынести в отдельный метод
                Console.WriteLine("Ââåäèòå ÷èñëî, âîçâîäèìîå â êâàäðàò: ");
                num1ques = byte.Parse(Console.ReadLine());

                Console.WriteLine("Ðåçóëüòàò: " + (num1ques * num1ques));
                Console.ReadLine();

                Console.ReadKey();

            }

            else if (operation = '%')
            {

                int num2ques;

                Console.WriteLine("Ââåäèòå ïåðâîå ÷èñëî: ");
                num2ques = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Ðåçóëüòàò: " + (num2ques % num2ques));
                Console.ReadLine();

            }
        }
        static void SelectOperation ()
        {
             Console.WriteLine("Âûáåðèòå îïåðàöèþ (+,-,*,/,^,%): ");
            operation = char.Parse(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
          
        }

        static void GetNums()
        {
                Console.WriteLine("Ââåäèòå ïåðâîå ÷èñëî: ");
                first_num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ââåäèòå âòîðîå ÷èñëî: ");
                second_num = Convert.ToInt32(Console.ReadLine());
        }
 
    }
}
