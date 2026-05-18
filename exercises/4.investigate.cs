// Snippet A
try
{
    int[] arr = new int[3];
    arr[10] = 5;
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("Index is out of range");
}

// Snippet B
try
{
    string s = null!;
    Console.WriteLine(s.Length);
}
catch (NullReferenceException)
{
    Console.WriteLine("do not use an object that is null");
}

// Snippet C
try
{
   int x = int.MaxValue;
    checked { x = x + 1; }   // checked enforces overflow detection 
}
catch(OverflowException)
{
    Console.WriteLine("The result is greater than the max value of int");
}

