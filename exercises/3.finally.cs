// exercise 3
Console.WriteLine("enter an integer");
try
{
    int n =int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        Console.WriteLine("even");
    }
    else
    {
        Console.WriteLine("odd");
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter an integer");
}
finally
{
    Console.WriteLine("thank you for using the program");
}
