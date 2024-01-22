System.Console.WriteLine("The first number is: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("The operation is: ");
char a = Convert.ToChar(Console.ReadLine());
System.Console.WriteLine("The second number is: ");
int y = Convert.ToInt32(Console.ReadLine());
int Sum(int a, int b)
{
    return a + b;
}
int Substract(int a, int b)
{
    return a - b;
}
int Multiplication(int a, int b)
{
    return a * b;
}
int Division(int a, int b)
{
    return a / b;
}
if (a == '+') System.Console.WriteLine(x + " + " + y + " = " + Sum(x, y));
else if (a == '-') System.Console.WriteLine(x + " - " + y + " = " + Substract(x, y));
else if (a == '/') System.Console.WriteLine(x + " / " + y + " = " + Division(x, y));
else if (a == '*') System.Console.WriteLine(x + " * " + y + " = " + Multiplication(x, y));
else System.Console.WriteLine("Error");