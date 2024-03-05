namespace Homework6

{
    public class Professor
    {
        public string? profName { get; set; }
        public string? classTeach { get; set; }
        private double salary;

        public Professor() { }

        public void Initialize(string name, string course, double salary)
        {
            profName = name;
            classTeach = course;
            SetSalary(salary);
        }

//Setting the salary and handling salaries that were input as negative values
        public void SetSalary(double salary_amount)
        {
            if (salary_amount >= 0)
                salary = salary_amount;
            else
                throw new ArgumentException("Salary cannot be negative.");
        }

        public double GetSalary()
        {
            return salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Professor {profName} teaches {classTeach} and makes {GetSalary()} dollars.");
        }
    }

    public class Student
    {
        public string? studentName { get; set; }
        public string? classEnroll { get; set; }
        private double studentGrade;

        public Student() { }

        public void Initialize(string name, string course, double grade)
        {
            studentName = name;
            classEnroll = course;
            SetGrade(grade);
        }

// Setting the grade and handling grades outside the range 0-100.
        public void SetGrade(double newGrade)
        {
            if (newGrade >= 0 && newGrade <= 100)
                studentGrade = newGrade;
            else
                throw new ArgumentException("Grade must be between 0 and 100.");
        }

        public double GetGrade()
        {
            return studentGrade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{studentName} is a student enrolled in {classEnroll} and has a grade of {GetGrade()}.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

// Creating 2 new professors and 2 new students
            Professor prof1 = new Professor();
            prof1.Initialize("Alice", "Java", 9000);

            Professor prof2 = new Professor();
            prof2.Initialize("Bob", "Math", 8000);

            Student stud1 = new Student();
            stud1.Initialize("Lisa", "Java", 90);

            Student stud2 = new Student();
            stud2.Initialize("Tom", "Math", 80);

// Printing the salaries and grades for teachers and students, respectively
            prof1.PrintInfo();
            prof2.PrintInfo();
            Console.WriteLine();

            stud1.PrintInfo();
            stud2.PrintInfo();
            Console.WriteLine();

//Calculations
            double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
            Console.WriteLine($"The difference between the salaries of {prof1.profName} and {prof2.profName} is {salaryDifference} dollars.");

            double totalGrade = stud1.GetGrade() + stud2.GetGrade();
            Console.WriteLine($"The combined grade for {stud1.studentName}'s {stud1.classEnroll} course and {stud2.studentName}'s {stud2.classEnroll} course is {totalGrade} points.");
        }
    }
}