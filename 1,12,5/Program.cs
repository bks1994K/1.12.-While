int number = Convert.ToInt32(Console.ReadLine());
int left = 1;
int right = number;
int i = 0;
while (i*i*i!=number)
{
    i = (right - left + 1) / 2;
    if (i * i * i > number)
    {
        right = i;
    }
    else if (i * i * i < number)
    {
        left = i;
    }

}
    Console.WriteLine(i);
