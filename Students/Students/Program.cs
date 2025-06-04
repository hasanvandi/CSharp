using System.Threading.Channels;

Console.WriteLine("Hello everybody.welcom to app");
//تعداد دانش اموزان در کلاس
int numStudentClass = 0;
//کنترل ورودی کاربر
bool isValaid = false;
while (!isValaid)
{
    Console.Write("Number of students in the class:");
    try
    {
        numStudentClass = int.Parse(Console.ReadLine());
        if(numStudentClass > 0)
        {
            isValaid = true;
        }
        else
        {
            Console.WriteLine("try again");
        }
    }
    catch(FormatException)
    {
        Console.WriteLine("Please enter a valid number");
    }
}
Console.WriteLine();

List<string> students =new List<string>(new string[numStudentClass]);
List<double> studentGrade = new List<double>(new double[students.Count]);



bool isValiadCharachter = false;
while (!isValiadCharachter)
{
    Console.WriteLine("[S]ee All Students");
    Console.WriteLine("[A]dd student");
    Console.WriteLine("[G]PA student");
    Console.WriteLine("[C]lass Average");
    Console.WriteLine("[E]xit");

    string input = Console.ReadLine();
    switch (input)
    {
        case "S":
        case "s":
            SeeAllStudents();
            break;
        case "A":
        case "a":
            AddToList();
            break;
        case "G":
        case "g":
            GPA();
            break;
        case "C":
        case "c":
            GPAAvrage();
            break;
        case "E":
        case "e":
            isValaid=true;
            break;
        default:
            Console.WriteLine("Please Enter right Character.");
            break;
            
    }
}
 double GPAAvrage()
{
    Console.WriteLine();
    double total = 0;
    for (int i = 0; i < numStudentClass; i++)
    {
        total += studentGrade[i];
    }
    double Avrage = total / numStudentClass;
    Console.WriteLine($"Is class Avrage:{Avrage}");
    Console.WriteLine();

    return Avrage;

    
    
}

void GPA()
{
    Console.WriteLine();

    for (int i = 0; i < students.Count; i++)
    {
        Console.Write($"Enter the student GPA {i + 1}:");
        studentGrade[i] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine();

}

void AddToList()
{
    Console.WriteLine();

    for (int i = 0; i < numStudentClass; i++)
    {
        Console.Write($"Enter fullName of the student {i + 1}:");
        students[i] = Console.ReadLine();
    }
    Console.WriteLine();

}

void SeeAllStudents()
{
    Console.WriteLine();

    for (int i = 0; i < students.Count; i++)
    {
        string itemFullName = students[i];
        Console.WriteLine(itemFullName);
    }
    Console.WriteLine();

}




Console.ReadLine();