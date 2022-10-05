int number = Convert.ToInt32(Console.ReadLine());
while (number != 0)
{
    int temp = number % 10;
    Console.Write(temp);
    number = number / 10;
}