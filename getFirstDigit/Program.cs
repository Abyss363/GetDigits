try {
    Console.Write("Input an integer: ");
    string num = Console.ReadLine();
    int numLength = num.Length;

    int[] numArray = new int[numLength];

    for (int i = 0; i < numLength; i++)
    {
        numArray[i] = Convert.ToInt32(num.Substring(i, 1));

    }

    foreach(int i in  numArray)
    {
        Console.Write(i);
    }
}
catch
{
    Console.WriteLine("\nSomething Went Wrong");
}
finally
{
    Console.WriteLine("\nThank you for using our program");
}
