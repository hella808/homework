using System;
using Calculate;

Calculating calculating = new Calculating();
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
        break;
    }
    else
    {
        continue;
    }
}