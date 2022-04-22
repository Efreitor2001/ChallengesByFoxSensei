void Pal(int a)
{
    int b = a;
    int c = 0;
    while (b != 0)
    {
        c = c * 10 + (b % 10);
        b /= 10;
    }
    if (a == c)
    {
        Console.WriteLine("is Pal");
    }
    else
    {
        Console.WriteLine("is NOT Pal");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Pal(num);