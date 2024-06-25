// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Dictionaries!");

Dictionary<double, string> students = [];
string newStudent;

Console.WriteLine("Enter your students (or ENTER to finish):");

do
{
    Console.WriteLine("Student name: ");
    string input = Console.ReadLine();
    newStudent = input;

    if (!Equals(newStudent, "")) {
        Console.WriteLine("Student ID");
        input = Console.ReadLine();
        double newStudentId = double.Parse(input);
        students.Add(newStudentId, newStudent);
    }
    
} while(!Equals(newStudent, ""));

foreach(KeyValuePair<double, string>student in students) {
    Console.WriteLine(student.Key + " : " + student.Value);
}
