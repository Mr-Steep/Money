﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Money
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            double x = 1;
            while (x > 0)
            {
                Console.WriteLine("Введите денежную сумму");
                string str = Console.ReadLine();
                string Newstr = null;
                char[] arr = str.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    if (arr[i] == '.')
                    {
                        arr[i] = ',';
                    }
                    Newstr += arr[i];
                }

                x = Convert.ToDouble(Newstr);


                while (x > 0)
                {

                    int ix = (int)x;
                    int w = 1;
                    while (w > 0)
                    {

                        Console.WriteLine("Выбрать действие и нажать ENTER");
                        Console.WriteLine("1 - Сложение");
                        Console.WriteLine("2 - Вычитание");
                        Console.WriteLine("3 - Умножение");
                        Console.WriteLine("4 - Деление");
                        Console.WriteLine("5 - Инкремент, число увеличивается на 0,01 копейку");
                        Console.WriteLine("6 - Декремент, число уменьшается на 0,01 копейку");
                        Console.WriteLine("7 - Перегрузка оператора == ");
                        Console.WriteLine("8 - Перегрузка оператора != ");

                        int a = Convert.ToInt32(Console.ReadLine());
                        Money c = new Money { Value = ix };


                        switch (a)
                        {
                            case 1:
                                {
                                    Console.WriteLine($"Введите сумму, которую нужно добавить к введенной  {x}");
                                    double sum = Convert.ToDouble(Console.ReadLine());
                                    Money c1 = new Money { DValue = sum };
                                    Console.WriteLine(c1.DValue + x);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine($"Введите число, которую нужно отнять к введенной  {x}");
                                    double sum = Convert.ToDouble(Console.ReadLine());
                                    Money c1 = new Money { DValue = sum };
                                    Console.WriteLine(x - c1.DValue);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine($"Введите число, к которуй нужно умножить к введенной  {x}");
                                    double sum = Convert.ToDouble(Console.ReadLine());
                                    Money c1 = new Money { DValue = sum };
                                    Console.WriteLine(x * c1.DValue);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine($"Введите число, на которое нужно разделить  {x}");
                                    double sum = Convert.ToDouble(Console.ReadLine());
                                    Money c1 = new Money { DValue = sum };
                                    Console.WriteLine(x / c1.DValue);
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine($"Число  {x}   увеличиться на 0.01 ");
                                    Money c1 = new Money { DValue = x };
                                    Console.WriteLine((++c1).DValue);
                                }
                                break;


                            case 6:
                                {
                                    Console.WriteLine($"Число  {x}   уменьшится на 0.01 ");
                                    Money c1 = new Money { DValue = x };
                                    Console.WriteLine((--c1).DValue);
                                }
                                break;

                            case 7:
                                {
                                    Console.WriteLine("Введите число для сравнения равенства");
                                    double sum = Convert.ToDouble(Console.ReadLine());
                                    Money c1 = new Money { DValue = sum };
                                    Console.WriteLine(x == c1.DValue);
                                }
                                break;
                            case 8:
                                {
                                    Console.WriteLine("Введите число для сравнения неравенства");
                                    double sum = Convert.ToDouble(Console.ReadLine());
                                    Money c1 = new Money { DValue = sum };
                                    Console.WriteLine(x != c1.DValue);
                                }
                                break;




                        }
                        if (x <= 0)
                        {
                            Console.WriteLine("Денег в кошельке меньше 0");
                        }

                        Console.WriteLine("Повторить операцию?");
                        Console.WriteLine("1 - Да");
                        Console.WriteLine("0 - Нет");
                        w = Convert.ToInt32(Console.ReadLine());
                        if (w == 0)
                        {
                            Console.WriteLine(" Bye-Bye");
                            x = 0;
                        }

                    }
                }
                if (x < 0)
                {

                    Console.WriteLine("У вас отрицательное  число, если хотите продолжить нажмите 1 \n для выхода ENTER || 0  ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        x = 1;
                    }
                    else x = 0;
                    Console.WriteLine(" Bye-Bye");

                }
            }
            
            

        }
    }
}
