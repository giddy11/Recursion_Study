// See https://aka.ms/new-console-template for more information

int Factorial(int num)
{
    if (num == 1)
        return 1;

    return num * Factorial(num - 1);
}

Console.WriteLine(Factorial(5));
