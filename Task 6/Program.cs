class Program
{
    static void Main()
    {
        // List of favorite fruits
        List<string> fruits = new List<string>() { "Mango", "Apple", "Banana" };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Apple");

        // Print all fruits
        Console.WriteLine("Fruits List");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Dictionary with fruit IDs
        Dictionary<int, string> fruitDict = new Dictionary<int, string>()
        {
            {1, "Mango"},
            {2, "Banana"},
            {3, "Orange"}
        };

        // Add a new entry
        fruitDict.Add(4, "Grapes");

        // Print dictionary key-value pairs
        Console.WriteLine("\n Fruit Dictionary");
        foreach (KeyValuePair<int, string> item in fruitDict)
        {
            Console.WriteLine($"ID: {item.Key} -> Fruit: {item.Value}");
        }
    }
}
