namespace Homework4Q1;

class Program
{

        // Method for comparing numbers
        static int Largest(int a, int b)
    {
        return a > b ? a : b;
    }

    // Main method
    static void Main(string[] args)
    {
            // Prompt user input, check validity
            Console.WriteLine("Please enter an integer:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid entry. Please enter a valid number.");
                return;
            }

            Console.WriteLine("Please enter another integer:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid entry. Please enter a valid number.");
                return;
            }

            // Compare user input, output results
            int largestNum = Largest(a, b);
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine($"The largest number is: {largestNum}");
        }
}