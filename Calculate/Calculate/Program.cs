using System;
using Calculate;

Calculating calculating = new Calculating();
UpCalculating upcalculating = new UpCalculating();
while (true)
{
    Console.WriteLine("Введите первое число");
    string FirstInput = Console.ReadLine();
    int num1 = int.Parse(FirstInput);
    Console.WriteLine("Введите второе число");
    string SecondInput = Console.ReadLine();
    int num2 = int.Parse(SecondInput);
    Console.WriteLine("Введите операцию (+,-,*,/)");
    string Symbol = Console.ReadLine();
    if (Symbol == "+")
    {
        Console.WriteLine(calculating.Addition(num1, num2));
    }
    else if (Symbol == "-")
    {
        Console.WriteLine(calculating.Subtraction(num1, num2));
    }
    else if (Symbol == "*")
    {
        Console.WriteLine(calculating.Multiplication(num1, num2));
    }
    else if (Symbol == "/")
    {
        Console.WriteLine(calculating.Division(num1, num2));
    }

    Console.WriteLine("Хотите ли вы завершить работу?");
    string choose = Console.ReadLine();
    if (choose == "да")
    {
        Console.WriteLine("Хотите ли вы попробовать другой калькулятор?");
        string chose = Console.ReadLine();
        if (chose == "да")
        {
            Console.WriteLine("Введите число:");
            string Input = Console.ReadLine();
            int num3 = int.Parse(Input);
            Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц, 7 - выход");
            string Math = Console.ReadLine();
            if (Math == "1")
            {
                Console.WriteLine(upcalculating.Exponentiation2(num3));
            }
            else if (Math == "2")
            {
                Console.WriteLine(upcalculating.Exponentiation3(num3));
            }
            else if (Math == "3")
            {
                Console.WriteLine(upcalculating.Root(num3));
            }
            else if (Math == "4")
            {
                Console.WriteLine(upcalculating.Cos(num3));
            }
            else if (Math == "5")
            {
                Console.WriteLine(upcalculating.Sin(num3));
            }
            else if (Math == "6")
            {
                Console.WriteLine(upcalculating.Tan(num3));
            }
            else if (Math == "7")
            {
                break;
            }
        }
        else
        {
            break;
        }
    }
    else
    {
        continue;
    }
}