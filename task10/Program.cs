int a=0, b = 1;
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write(0 + " ");
System.Console.Write(1 + " ");
void Fibonachi(int n)
{

    
    if (n - 2 == 0) return;
    else 
    {
        int d = a+b;
        System.Console.Write(d + " ");
        a = b;
        b = d;
        Fibonachi(n - 1);
        
    }

}

Fibonachi(n);

