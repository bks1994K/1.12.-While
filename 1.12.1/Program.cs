int number = Convert.ToInt32(Console.ReadLine());
int tmp = 1;
    if (number < 0)
    {
        number = -number;
    }
int m = number - 1;
while (tmp!=0 && m!=0)
{
        tmp = number %m;
        if (tmp == 0)
    {
        Console.WriteLine(m);
    }
    m=m - 1;
}