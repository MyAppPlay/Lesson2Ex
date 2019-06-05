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
        {                             // Гаврилов Владимир
            #region Ex1
            ////Написать метод, возвращающий минимальное из трёх чисел.
            //Console.WriteLine("Введите поочередно три разных целых числа");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c)
            //{
            //    Console.WriteLine("Самое маленькое число " + a);
            //}
            //else if (b < a && b < c)
            //{
            //    Console.WriteLine("Самое маленькое число " + b);
            //}
            //else Console.WriteLine("Самое маленькое число " + c);

            #endregion

            #region Ex2
            //// Написать метод подсчета количества цифр числа.
            //Console.WriteLine("Введите любое целое число");
            //string d = Console.ReadLine();
            //Console.WriteLine("Количество цифр в числе " + d.Length);

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

            #region Ex4
                        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
                        //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
                        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа 
                        //    пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
            string login = "root";
            string password = "GeekBrains";

            bool autorization = false;

            int count = 0;

            do
            {
                autorization = Autorization(login, password, autorization);

                if (autorization == true)
                {
                    Console.WriteLine("Добро пожаловать");
                    break;
                }
                else Console.WriteLine("Доступ закрыт\n");
                count++;
            } while (count < 3);
            if (count == 3)
            {
                Console.WriteLine("Все попытки использованы, попрубуйте в другой раз");
            }
            #endregion

            #region Ex5
            //а) Написать программу, которая запрашивает массу и рост человека,
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Какой у вас вес?(кг)");
            int weight = int.Parse (Console.ReadLine());

            Console.WriteLine("Какой у вас рост?(см)");
            double height = double.Parse (Console.ReadLine())/100;

            double imt = weight / (height * height);

            double norm = (height*100) - (100 + (((height*100) - 100) / 15));//идеальный средний вес
            norm = Math.Round(norm, 0);
            

            if (imt < 185 / 10)
            {
                
                Console.WriteLine("Набирайте вес. До нормы не хватает "+(norm-weight)+" кг");
            }
            else if (imt > 25)
            {
                Console.WriteLine("Худейте. Для нормы нужно сбросить "+(weight-norm)+" кг");
            }
            else Console.WriteLine("Всё в норме ");

            #endregion
            Console.ReadKey();
        }
        //реализация метода ввода пароля для Ex4
        private static bool Autorization(string login, string password, bool autorization)
        {
            Console.WriteLine("Введите логин:\n ");
            string checkLogin = Console.ReadLine();

            Console.WriteLine("Введите пароль:\n ");
            string checkPassword = Console.ReadLine();

            if (login == checkLogin && password == checkPassword)
            {
                autorization = true;
            }

            return autorization;
        }
    }
}
