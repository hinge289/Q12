class Student
{
    private string name;
    private int rollNumber;
    private int marks;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            { 
                name = value; 
            }
            else
            {
                throw new ArgumentException("Name cannot be empty or null.");
            }

        }
        }

    public int RollNumber
    {
        get { return rollNumber; }
        set
        {
            if (value > 0)
            {
                rollNumber = value;
            }
            else
            {
                throw new ArgumentException("Roll number must be positive.");
            }
        }
    }

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
            else {

                throw new ArgumentException("Marks must be between 0 and 100.");
                }
        }
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Marks: {Marks}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Student student = new Student();
            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            student.RollNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            student.Marks = int.Parse(Console.ReadLine());

            Console.WriteLine("\nStudent Information:");
            student.DisplayStudentInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
