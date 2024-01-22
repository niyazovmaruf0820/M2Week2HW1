int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
for (int i = x; i <= y; i++)
{
    for (int j = 1;j <= 10; j++)
    {
        System.Console.WriteLine(i + " * " + j + " = " + (i * j));
    }
    System.Console.WriteLine("-------------------------------");
}