namespace Homework5Q1;

class Program
{
    static void Main(string[] args)
    {
        // Takes user inputs
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine()!);
        
        int largest = FindLargest(a, b);

        // Prints phrase and largest number
        Console.WriteLine($"The largest number is: {largest}");
    }
    // Find the largest number
    static int FindLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }
}