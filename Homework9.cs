namespace Homework9;

class Student
{
    //Creating the Student class
    private int studentID;
    private string studentName;
    public static List <Student> studentList = new List <Student>();

    public Student (int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
    }

    public string GetStudentName()
    {
        return studentName;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating Students
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        // Adding the name-grade pairs to a gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // Checking whether a record for Tom exists in the gradebook. If not, adding Tom.
        if(!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        //Calculating the average GPA of all students
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }

        double averageGPA = totalGPA / gradebook.Count;

        // Printing the average GPA & information about students with a GPA higher than the average.
        Console.WriteLine("The average GPA is: " + averageGPA.ToString("F2"));
        
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.GetStudentName()) && gradebook[student.GetStudentName()] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
