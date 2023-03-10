// See https://aka.ms/new-console-template for more information


//Console.WriteLine(Factorial(5));
//Console.WriteLine(Power(2, 4));
//Console.WriteLine(Walk(5));
//Console.WriteLine(SumNumbers(5));
//Console.WriteLine(GridPaths(3,3));
Console.WriteLine(SumDigits(9));
Console.WriteLine(SumDigits(7));
Console.WriteLine(SumDigits(3));
Console.WriteLine(SumDigits(1));
Console.WriteLine(SumDigits(0));
Console.WriteLine(SumDigits(21));
Console.WriteLine(SumDigits(45));
Console.WriteLine(SumDigits(93));
Console.WriteLine(SumDigits(15));
Console.WriteLine(SumDigits(129));


int SumDigits(int n)
{
    if (n < 10 && n >= 0) return n;

    return SumDigits(n % 10) + SumDigits(n / 10);
}

int GridPaths(int n, int m)
{
    if (n == 1 || m == 1) return 1;

    return GridPaths(n, m - 1) + GridPaths(m - 1, n);
}

int SumNumbers(int num)
{
    int sum = 0;
    if (num == 0) return 0;

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

