namespace Homework2Bonus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year: ");
        
        //int year = 2008; // leap year to test the program
        //int year = 1900; // non-leap year to test the program
    
    // Get user input as variable year
        int year = Convert.ToInt16(Console.ReadLine());
    
    /* Checks if the year is evenly divisible by 4, 
    and not by 100 or evenly divisible by 400. */
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else 
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
