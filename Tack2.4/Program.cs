using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (n >= 100 && n <= 999)
            {
                int a = n / 100;
                int b = (n % 100) / 10;
                int c = (n % 100) % 10;
                switch (a)
                {
                    case 1:
                        {
                            Console.Write("сто");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("двести");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("триста");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("четыреста");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пятьсот");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шестьсот");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семьсот");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемьсот");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("девятьсот");
                            break;
                        }
                }
                if (b != 0 || c > 0)
                {
                    Console.Write(" ");
                    switch (b)
                    {
                        case 1:
                            {
                                if (c == 0)
                                {
                                    Console.Write("десять");
                                }
                                else
                                {
                                    switch (c)
                                    {
                                        case 1:
                                            {
                                                Console.Write("одиннадцать");
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Write("двенадцать");
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Write("тринадцать");
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.Write("четырнадцать");
                                                break;
                                            }
                                        case 5:
                                            {
                                                Console.Write("пятнадцать");
                                                break;
                                            }
                                        case 6:
                                            {
                                                Console.Write("шестнадцать");
                                                break;
                                            }
                                        case 7:
                                            {
                                                Console.Write("семнадцать");
                                                break;
                                            }
                                        case 8:
                                            {
                                                Console.Write("восемнадцать");
                                                break;
                                            }
                                        case 9:
                                            {
                                                Console.Write("девятнадцать");
                                                break;
                                            }
                                    }
                                }

                                break;
                            }
                        case 2:
                            {
                                Console.Write("двадцать");
                                break;
                            }
                        case 3:
                            {
                                Console.Write("тридцать");
                                break;
                            }
                        case 4:
                            {
                                Console.Write("сорок");
                                break;
                            }
                        case 5:
                            {
                                Console.Write("пятьдесят");
                                break;
                            }
                        case 6:
                            {
                                Console.Write("шестьдесят");
                                break;
                            }
                        case 7:
                            {
                                Console.Write("семьдесят");
                                break;
                            }
                        case 8:
                            {
                                Console.Write("восемьдесят");
                                break;
                            }
                        case 9:
                            {
                                Console.Write("девяносто");
                                break;
                            }
                    }
                    if ((b != 0 && b != 1) || c > 0)
                    {
                        Console.Write(" ");
                        switch (c)
                        {
                            case 1:
                                {
                                    Console.Write("один");
                                    break;
                                }
                            case 2:
                                {
                                    Console.Write("два");
                                    break;
                                }
                            case 3:
                                {
                                    Console.Write("три");
                                    break;
                                }
                            case 4:
                                {
                                    Console.Write("четыре");
                                    break;
                                }
                            case 5:
                                {
                                    Console.Write("пять");
                                    break;
                                }
                            case 6:
                                {
                                    Console.Write("шесть");
                                    break;
                                }
                            case 7:
                                {
                                    Console.Write("семь");
                                    break;
                                }
                            case 8:
                                {
                                    Console.Write("восемь");
                                    break;
                                }
                            case 9:
                                {
                                    Console.Write("девять");
                                    break;
                                }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }

    }
}

        
    

