using System;

namespace Classes;

public class Student
{
    //Auto-implemented properties
    public string Name { get; set; }
    public int StudentId { get; set; }
    public int NumberOfCredits { get; set; }
    public double Gpa { get; set; }

    //constructor

    public Student(string name, int studentId, int numberOfCredits, double gpa)
    {
        Name = name;
        StudentId = studentId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    //overload
    public Student(string name, int studentId, int numberOfCredits)
        : this(name, studentId, numberOfCredits, 0) { }

}
