int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    int cnt = 0;
    for (int j = 0; j < a; j++)
    {
        if (arr[i] == arr[j] && i != j) cnt++;
    }
    if (cnt != 0) System.Console.Write(arr[i] + " ");
}












// Array.Sort(arr);
// for (int i = 0; i < a - 1; i++)
// {
//     if (arr[i] == arr[i + 1] || arr[i] == arr[i - 1]) System.Console.Write(arr[i] + " ");
// }
