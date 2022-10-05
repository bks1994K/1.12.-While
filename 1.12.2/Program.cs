int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int nod = 1;
int temp = -1;

while (temp != 0)
{
    if (b > a)
    {
        int d = a;
        a = b;
        b = d;
    }
    temp = a % b;
    if (temp == 0)
    {
        nod = b;
        Console.WriteLine(nod);
    }
    else if (temp != 0)
    {
        if (a > b)
        {
            a = temp;
            nod = b / a;
        }
        else if (b > a)
        {
            b = temp;
            nod = a / b;
        }
      
    }

}