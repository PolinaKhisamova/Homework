Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if(number>1)
{
    int count = 2;
    while(count<=number)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
else
{
    Console.WriteLine("No even numbers between 1 and " + number);
}