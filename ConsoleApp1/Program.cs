﻿// See https://aka.ms/new-console-template for more information


//Console.WriteLine(Factorial(5));
//Console.WriteLine(Power(2, 4));
//Console.WriteLine(Walk(5));
Console.WriteLine(SumNumbers(5));

int SumNumbers(int num)
{
    int sum = 0;
    if (num == 0) return 1;

    return num + SumNumbers(num - 1);
}

int Walk(int steps)
{
    if (steps < 1) return 1;
    Console.WriteLine("You take a step!");
    return Walk(steps - 1);
}

int Factorial(int num)
{
    if (num == 1)
        return 1;

    return num * Factorial(num - 1);
}

float Power(float num, int powerOf)
{
    if (powerOf == 1)
        return 1;

    return num * Power(num, powerOf - 1);
}

