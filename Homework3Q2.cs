namespace Homework3Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");

        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            // Outputs correct number of rows
            for (int i = 0; i < N; i++)
            {
                // Outputs correct number of columns
                for (int j = 0; j < N; j++)
                {
                        Console.Write("#");
                }
                // After completing row, move to new line
                Console.WriteLine(); 
            }
        }
        // Considers invalid entries like decimals and negatives
        else
        {
            Console.WriteLine("Invalid entry. Please enter a positive integer.");
        }
    }
}
