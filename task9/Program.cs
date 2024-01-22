int Pow(int a, int b)
{
    if (b == 0) return 1;
    else return a = a * Pow(a, b-1);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Pow(a, b));