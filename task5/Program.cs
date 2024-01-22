int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 1; i < a; i++)
{
    if (arr[i - 1] < arr[i]) cnt++;
}
System.Console.WriteLine(cnt);