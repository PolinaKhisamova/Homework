Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number");
int num3 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    if(num1>num3)
    {
        Console.WriteLine("max - " + num1);
    }
    else
    {
        Console.WriteLine("max - " + num3);
    }
}
else
{
    if(num2>num3)
    {
        Console.WriteLine("max - " + num2);
    }
    else
    {
        Console.WriteLine("max - " + num3);
    }
}