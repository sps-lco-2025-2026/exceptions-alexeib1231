Console.Write("Enter a number: ");
try
{
    int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(100 / n);
}
catch (FormatException)
{
    Console.WriteLine("please enter an integere");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Do not enter 0");
}
finally
{
    Console.WriteLine("Calculation complete");
}