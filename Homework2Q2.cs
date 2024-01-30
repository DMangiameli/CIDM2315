namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {
    // Prompts to input 3 numbers
        Console.WriteLine("Input the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Input the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());
    
    // Declaring smallest number variable
        int smallestNum = (num1 < num2 && num1 < num3) ? num1 : (num2 < num3) ? num2 : num3;
    // Outputs a message and the smallest number    
        Console.WriteLine($"The smallest value is: {smallestNum}");
    }
}
