int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int even = 0;
int z = 0;
int odd = 0;
int p = 0;
int sum = 0;
int min = 0;
int n = 0;
int max = 0;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] == 0) z++;
    if (arr[i] > 0) p++;
    if (arr[i] < 0) n++;
    if (arr[i] % 2 == 0 && arr[i] != 0) even++;
    if (arr[i] % 2 != 0 && arr[i] != 0) odd++;
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
    sum += arr[i];
}
System.Console.WriteLine("Negative: " + n);
System.Console.WriteLine("Pozitive: " + p);
System.Console.WriteLine("Zerous: " + z);
System.Console.WriteLine("Even: " + even);
System.Console.WriteLine("Odd: " + odd);
System.Console.WriteLine("Max: " + max);
System.Console.WriteLine("Min: " + min);
System.Console.WriteLine("Sum of Digits: " + sum);
