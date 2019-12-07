using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(age >= 18 ? "Взрослый" : "Ошибка ввода или несовершеннолетний");
                /*if (age > 18)
                {
                    Console.WriteLine("Взрослый");
                }
                else if(age == 0)
                {
                    Console.WriteLine("Новорожденный");
                }
                else if (age >= 7 && age < 18)
                {
                    Console.WriteLine("Школьник");
                }
                else if (age == 18)
                {
                    Console.WriteLine("Выпускник(ца)");
                }
                else if (age > 0 && age < 7 )
                {
                    Console.WriteLine("Ребенок");
                }*/
                switch (age)
                {
                    case 0:
                        {
                            Console.WriteLine("Новорожденный");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Школьник");
                            break;
                        }
                    case 18:
                        {
                            Console.WriteLine("Выпускник(ца)");
                            break;
                        }
                    case 20:
                        {
                            Console.WriteLine("Взрослый");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого значения нету");
                            break;
                        }
                }
                Console.WriteLine("Конец выполнения программы");
            }
            catch
            {
                Console.WriteLine("Неправильное значение. Повторите ввод");
            }

            Console.ReadKey();
        }
    }
}
