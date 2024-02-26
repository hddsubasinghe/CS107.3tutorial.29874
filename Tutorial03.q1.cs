using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial03q1cs { 


class Course
{
    private string courseName;
    private string instructorName;
    private double grade;

    public Course(string courseName, string instructorName, double grade)
    {
        CourseName = courseName;
        SetInstructorName(instructorName);
        Grade = grade; 
    }

    public string CourseName { get; private set; }

    public double Grade
    {
        get { return grade; }
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }
            grade = value;
        }
    }

    public void SetInstructorName(string instructorName)
    {
        if (string.IsNullOrWhiteSpace(instructorName))
        {
            throw new ArgumentException("Instructor name cannot be empty or null.");
        }
        this.instructorName = instructorName;
    }

    private string CalculateLetterGrade()
    {
        if (grade >= 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }

    public void PrintCourseInfo()
    {
        string letterGrade = CalculateLetterGrade();
        Console.WriteLine($"Course: {CourseName}");
        Console.WriteLine($"Instructor: {instructorName}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
    }
}

    class Program
    {
        static void Main()
        {
            try
            {
                Course mathCourse = new Course("Science", "Mr.Nimal", 92.5);
                mathCourse.PrintCourseInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}