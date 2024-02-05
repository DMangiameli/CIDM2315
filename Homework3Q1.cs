namespace Homework3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");

            // Prompts user input as variable n
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // Executes IsPrime if the user entry is valid
                IsPrime(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // Checks whether the input is prime or not, then outputs accordingly
        static void IsPrime(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine($"{number} is non-prime.");
                return;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is non-prime.");
                    return;
                }
            }

            Console.WriteLine($"{number} is prime.");
        }
    }
}