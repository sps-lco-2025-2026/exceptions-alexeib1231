
string[] names = { "Alice", "Bob", "Charlie" };
Console.Write("Enter an index: ");
try
{
   int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine(names[i]); 
}
catch (FormatException)
{
    Console.WriteLine("please enter an integer");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("That index is out of range, please enter a number between 0-2");
}

