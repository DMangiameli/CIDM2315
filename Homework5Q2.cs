namespace Homework5Q2;

class Program
{
    static void Main(string[] args)
    {
        // Takes user inputs
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the third integer: ");
        int c = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the fourth integer: ");
        int d = int.Parse(Console.ReadLine()!);

        //Call method that found largest among a & b
        int maxAB = FindLargest(a, b);

        // Call method that found largest amond c & d
        int maxCD = FindLargest(c, d);

        // Call method that found largest among all 4 inputs
        int largest = FindLargest(maxAB, maxCD);

        Console.WriteLine($"The largest number is: {largest}");
    }

    // Method to find largest among a & b
    static int FindLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // Method to find largest among all 4 inputs
    static int FindLargest(int a, int b, int c, int d)
    {
        // Using Q1 method to find largest among a & b
        int maxAB = FindLargest(a, b);

        // Using method to find largest among c & d
        int maxCD = (c > d) ? c : d;

        // Comparing largest of a & b to largest of c & d
        return (maxAB > maxCD) ? maxAB : maxCD;
        }
}