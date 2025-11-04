class Program
{
    static void Main()
    {
        // Variable declarations and initialization
        byte myByte = 10;
        short myShort = 300;
        int myInt = 1000;
        long myLong = 50000L;
        float myFloat = 3.5f;
        double myDouble = 7.123;
        decimal myDecimal = 15.75m;
        char myChar = 'A';
        bool myBool = true;

        // Type conversion
        int value = 42;
        string intToString = value.ToString(); 

        string piString = "3.14";
        double stringToDouble = Convert.ToDouble(piString); 

        // Output
        Console.WriteLine("=== Data Types and Values ===");
        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"bool: {myBool}");

        Console.WriteLine("Type Conversions ");
        Console.WriteLine($"Integer 42 as string: {intToString}");
        Console.WriteLine($"\"3.14\" as double: {stringToDouble}");
    }
}
