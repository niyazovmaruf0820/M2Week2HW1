int EvenCount(int n)
{
    int s = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if ((i % 10) % 2 == 0 && i % 10 != 0) s++;
    }
    return s;
}
int OddCount(int n)
{
    int s = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if ((i % 10) % 2 != 0) s++;
    }
    return s;
}
int ZeroCount(int n)
{
    int s = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 == 0) s++;
    }
    return s;
}
int DigitCount(int n)
{
    int s = 0;
    for (int i = n; i > 0; i /= 10)
    {
         s++;
    }
    return s;
}
int MinDigit(int n)
{
    int a = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 < a) a = i % 10;
    }
    return a;
}
int MaxDigit(int n)
{
    int a = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 > a) a = i % 10;
    }
    return a;
}
int SumDigit(int n)
{
    int s = 0;
    for (int i = n; i > 0; i /= 10)
    {
         s += i % 10;
    }
    return s;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Even: " + EvenCount(a));
System.Console.WriteLine("Odd: " + OddCount(a));
System.Console.WriteLine("Zerous: " + ZeroCount(a));
System.Console.WriteLine("Digits: " + DigitCount(a));
System.Console.WriteLine("Min: " + MinDigit(a));
System.Console.WriteLine("Max: " + MaxDigit(a));
System.Console.WriteLine("Sum of Digits: " + SumDigit(a));
