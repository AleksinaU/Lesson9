using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Я-калькулятор.");
            try
            {
                Console.Write("Введите целое число: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целое число: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите номер операции:");
                Console.WriteLine("1. сложение");
                Console.WriteLine("2. вычитание");
                Console.WriteLine("3. умножение");
                Console.WriteLine("4. деление");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0 || n > 4)
                {
                    Console.WriteLine("Нет операции с указанным кодом.");
                }
                else
                {
                    switch (n)
                    {
                        case 1: Console.WriteLine("Сумма чисел = {0}", x + y);break;
                        case 2: Console.WriteLine("Разность чисел = {0}", x - y); break;
                        case 3: Console.WriteLine("Произведение чисел = {0}", x * y);break;
                        case 4: if (y==0)
                                Console.WriteLine("Ошибка! деление на 0.");
                                else
                                Console.WriteLine("Частное чисел = {0:f2}", x/y);break;
                    }
                }         
            }
            catch(FormatException z)
            {
                Console.WriteLine("Неверный формат ввода."); 
            }
            Console.ReadKey();
        }
    }
}
