Console.Clear();
Console.WriteLine("Число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int M=b;
if (a >= b)
{
    M = a;
}
if (c >= b)
{
    M = c;
}
Console.Write("Наибольшее число: " + M);