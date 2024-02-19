namespace Homework5Q3;

class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        // Get current yearcd
        
        int year = DateTime.Now.Year;

        // Calculate age
        int age = year - birth_year;

        // Check if age is greater than or equal to 18
        return age >= 18;
    }
    static void createAccount()
    {
        // Get  username input
        Console.Write("Enter username: ");
        string username = Console.ReadLine()!;

        //Get password input
        Console.Write("Enter password: ");
        string password = Console.ReadLine()!;

        // Repeat password input for verification
        Console.Write("Re-enter password: ");
        string confirmPassword = Console.ReadLine()!;

        // Get user birthyear input
        Console.Write("Enter birth year: ");
        int birthYear = int.Parse(Console.ReadLine()!);

        // Check if age is greater than or equal to 18
        if (checkAge(birthYear))
        {
            // Check if passwords match
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}