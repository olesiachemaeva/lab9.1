using System;

namespace lab9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0, y = 0;
            int n = 0;
            Console.WriteLine("***Вас приветствует калькулятор!***");
            try
            {
                Console.WriteLine("Введите целое число. Х= ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число. Y= ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
                Console.ReadKey();
                return;
            }
           
            //Код операции
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("1-сложение");
            Console.WriteLine("2-вычетание");
            Console.WriteLine("3-произведение");
            Console.WriteLine("4-частное");
            Console.WriteLine($"Ваш выбор: ");

            //char c = char.Parse(Console.ReadLine());
            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Результат: {x}+{y}=" + (x + y));
                    break;
                case "2":
                    Console.WriteLine($"Результат: {x}-{y}=" + (x - y));
                    break;
                case "3":
                    Console.WriteLine($"Результат: {x}*{y}=" + (x * y));
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine($"Результат: {x}/{y}=" + (x / y));
                    }
                    catch
                    {
                        Console.WriteLine("Деление на 0");
                    }
                        break;
                default:
                    Console.WriteLine("Некорректная операция");
                    Console.ReadLine();
                    return;
            }
          
            /*Console.WriteLine("Результат: ");
            if (c == '1')
            {
                //1-СЛОЖЕНИЕ
                Console.WriteLine(x + y);
            }
            else
            if (c == '2')
            {
                //2-ВЫЧИТАНИЕ
                Console.WriteLine(x - y);
            }
            else
            if (c == '3')
            {
                //3-ПРОИЗВЕДЕНИЕ
                Console.WriteLine(x * y);
            }
            else
            if (c == '4')
                try
                {
                    //4-ЧАСТНОЕ
                    Console.WriteLine("Результат равен ={0:f2}", x / y);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            else { }*/

            Console.ReadKey();


        }
    }
}
