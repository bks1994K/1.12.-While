int number = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (number !=0)
{
    int temp = number % 10;
    if (temp % 2 != 0)
    {
        s = s + 1;
    } 
    number = number / 10;
   }
Console.WriteLine(s);