using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Ex
{
    class Program
    {
        static void Main(string[] args)
        {                             //Гаврилов Владимир
            #region Ex1
          //Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Введите поочередно три разных целых числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("Самое маленькое число " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Самое маленькое число " + b);
            }
            else Console.WriteLine("Самое маленькое число " + c);

            #endregion

            #region Ex2
          // Написать метод подсчета количества цифр числа.
            Console.WriteLine("Введите любое целое число");
            string d = Console.ReadLine();
            Console.WriteLine("Количество цифр в числе "+d.Length);

            #endregion

            #region Ex3
            //С клавиатуры вводятся числа,
            //пока не будет введен 0.Подсчитать сумму всех нечётных положительных чисел.
            Console.WriteLine("Введите несколько положительных чисел завершая нулем");

            int e = int.Parse(Console.ReadLine());
            int sum = 0;

            while (e != 0)
            {
                if (e % 2 != 0)
                {
                    sum = e + sum;
                }//Подсчет суммы нечетных чисел
                e = int.Parse(Console.ReadLine());

            } //Ввод чисел с клавиатуры
 
            Console.WriteLine("Сумма всех введенных нечетных чисел = " + sum);


            #endregion

           Console.ReadKey();

        }
    }
}
