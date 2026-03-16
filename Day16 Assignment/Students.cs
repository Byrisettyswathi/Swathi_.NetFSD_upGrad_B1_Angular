using System;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }

    public Student(int id, string name, int marks)
    {
        StudentId = id;
        Name = name;
        Marks = marks;
    }

    public virtual string CalculateGrade()
    {
        return Marks > 50 ? "Pass" : "Fail";
    }
}

class SchoolStudent : Student
{
    public SchoolStudent(int id, string name, int marks) : base(id, name, marks) { }
    public override string CalculateGrade()
    {
        return Marks > 40 ? "Pass" : "Fail";
    }
}

class CollegeStudent : Student
{
    public CollegeStudent(int id, string name, int marks) : base(id, name, marks) { }
    public override string CalculateGrade()
    {
        return Marks > 50 ? "Pass" : "Fail";
    }
}

class OnlineStudent : Student
{
    public OnlineStudent(int id, string name, int marks) : base(id, name, marks) { }
    public override string CalculateGrade()
    {
        return Marks > 60 ? "Pass" : "Fail";
    }
}

class Assignment5
{
    static void Main()
    {
        Student[] students =
        {
            new SchoolStudent(1, "keerthana", 45),
            new CollegeStudent(2, "Ammu", 55),
            new OnlineStudent(3, "Suunuu", 58)
        };

        foreach (Student s in students)
        {
            Console.WriteLine(s.Name + " : " + s.CalculateGrade());
        }
    }
}