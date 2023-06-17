Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine("max - " + num1 + ", min - " + num2);
}
else{
    Console.WriteLine("max - " + num2 + ", min - " + num1);
}