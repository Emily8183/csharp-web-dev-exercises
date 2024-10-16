//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Dictionary<string, int> students = new Dictionary<string, int>();

string studentName;

do
{
    Console.WriteLine("Whats your name");
    string input = Console.ReadLine();
    studentName = input;

    if (!Equals(studentName, ""))
    {
        Console.WriteLine("whats your id");
        input = Console.ReadLine();
        int studentId = int.Parse(input);
        students.Add(studentName, studentId);

    }

}
while (!Equals(studentName,"")); //condition, while this is true, run the above 

Console.WriteLine("here's a list of all the students");

foreach(KeyValuePair<string, int> student in students)
{
    Console.WriteLine(student.Key + " : " + student.Value);
}






