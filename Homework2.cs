namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
    //prompt user input
        Console.Write("Please enter a letter grade: ");
    //string grade = "A"; //assigning grade to test program
        string grade = Console.ReadLine();

        int gpaPoints;
    //convert input to uppercase to avoid case sensitivity
    //switch to assign GPA points to letter grade
        switch (grade.ToUpper())
        {
            case "A":
                gpaPoints = 4;
                break;
            case "B":
                gpaPoints = 3;
                break;
            case "C":
                gpaPoints = 2;
                break;
            case "D":
                gpaPoints = 1;
                break;
            case "F":
                gpaPoints = 0;
                break;
        //if invalid grade entered, output error message and leave the program
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return; 
        }
        Console.Write($"GPA point(s): {gpaPoints}");
    }
}
