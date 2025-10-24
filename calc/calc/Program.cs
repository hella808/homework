using System;
using Calc;

Calculator calculator = new Calculator();
while (true)
{
    Console.WriteLine("Выберете калькулятор (1 - Стандартный, 2 - Научный, 3 - Выход)");
    string chose = Console.ReadLine();
    if ( chose == "1")
    {
        Console.WriteLine("Введите первое число");
        string Num1Input = Console.ReadLine();
        int num1 = int.Parse(Num1Input);
        Console.WriteLine("Введите второе число");
        string Num2Input = Console.ReadLine();
        int num2 = int.Parse(Num2Input);
        Console.WriteLine("Введите операцию (+,-,*,/)");
        string Symbol = Console.ReadLine();
        if (Symbol == "+")
        {
            Console.WriteLine(calculator.Addition(num1, num2));
        }
        else if (Symbol == "-")
        {
            Console.WriteLine(calculator.Subtraction(num1, num2));
        }
        else if (Symbol == "*")
        {
            Console.WriteLine(calculator.Multiplication(num1, num2));
        }
        else if (Symbol == "/")
        {
            Console.WriteLine(calculator.Division(num1, num2));
        }
    }
    else if ( chose == "2" )
    {
        Console.WriteLine("Введите число:");
        string Input = Console.ReadLine();
        int num3 = int.Parse(Input);
        Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц");
        string Math = Console.ReadLine();
        if (Math == "1")
        {
            Console.WriteLine(calculator.Exponentiation2(num3));
        }
        else if (Math == "2")
        {
            Console.WriteLine(calculator.Exponentiation3(num3));
        }
        else if (Math == "3")
        {
            Console.WriteLine(calculator.Root(num3));
        }
        else if (Math == "4")
        {
            Console.WriteLine(calculator.Cos(num3));
        }
        else if (Math == "5")
        {
            Console.WriteLine(calculator.Sin(num3));
        }
        else if (Math == "6")
        {
            Console.WriteLine(calculator.Tan(num3));
        }
    }
    else if ( chose == "3")
    {
        break;
    }
}