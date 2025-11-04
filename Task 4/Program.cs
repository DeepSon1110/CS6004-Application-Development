// Task 4
class Program
{
    static void Main()
    {
        int[] array = { 3,4,5,6,7 };

        // Array.Sort()
        Array.Sort(array);
        Console.WriteLine("Sorted array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // Array.Reverse()
        Array.Reverse(array);
        Console.WriteLine("Reversed array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // Loop to print elements
        Console.WriteLine("Elements using for loop:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        // Array.IndexOf() to find the position of specific element
        int index = Array.IndexOf(array, 4);
        Console.WriteLine("\nIndex of 4 is: " + index);
    }
}

