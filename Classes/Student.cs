using System;

namespace Classes;

public class Student
{
    //Auto-implemented properties
    private string Name { get; set; }
    private int StudentId { get; set; }
    private int NumberOfCredits { get; set; }
    private double Gpa { get; set; }

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
