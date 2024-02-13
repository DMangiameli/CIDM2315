namespace Homework4Q2
{
    class Program
    {
        
        // Method for printing left triangle
        static void LeftTriangle(int N)
        {
            Console.WriteLine($"N is: {N}; shape is left");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
        // Method for printing right triangle
        static void RightTriangle(int N)
        {
            Console.WriteLine($"N is: {N}; shape is right");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer for the size of the triangle:");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                Console.WriteLine("Enter the shape direction (left or right):");
                string direction = Console.ReadLine()!;

                if (direction == "left")
                {
                    LeftTriangle(size);
                }
                else if (direction == "right")
                {
                    RightTriangle(size);
                }
                else
                {
                    Console.WriteLine("Invalid entry. Direction must be either 'left' or 'right'.");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a positive integer.");
            }
        }
    }
}