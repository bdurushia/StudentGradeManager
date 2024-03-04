using StudentGradeManager;

// declare new student list
var students = new List<Student>();

// Object initilzers for making new student objects
var valarie = new Student()
{
    Name = "Valarie",
    ID = 01
};

var kent = new Student()
{
    Name = "Kent",
    ID = 02
};

var brandyn = new Student()
{
    Name = "Brandyn",
    ID = 03
};

var alina = new Student()
{
    Name = "Alina",
    ID = 04
};

// Add students to student list
students.Add(valarie);
students.Add(kent);
students.Add(brandyn);
students.Add(alina);

valarie.AddGrade(98.5);
valarie.AddGrade(92.7, 90.8, 89.5, 97.5);

kent.AddGrade(92.5);
kent.AddGrade(99.2, 89.5, 73.2, 81.5);

brandyn.AddGrade(93.8);
brandyn.AddGrade(75.4, 85.5, 73.2, 82.7);

alina.AddGrade(99.8);
alina.AddGrade(92.5, 98.7, 93.5, 97.5);

// Formate and print student data
Console.WriteLine("STUDENT\t\tID\tGRADES\t\t\t\tFINAL GRADE");
Console.WriteLine("------------------------------------------------------------------");
foreach (var person in students)
{
    Student.ShowStudentInfo(person);
}