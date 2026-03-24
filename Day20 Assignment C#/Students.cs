namespace Assignment7
{
    internal class Students
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"Tina", 25, 87 ),
             new Student(2,"Ramya", 11, 68),
            new Student(3,"Priya", 21, 93 ),
            new Student(4,"Vihansh", 18, 90 ),
            new Student(5,"Ramu", 12, 78 ),
            };

            var result = students.Where(s => s.Marks > 75);
            foreach(var s in result)
            {
                Console.WriteLine(s.Name+ " "+ s.Marks);
            }

            var result1 = students.Where(s => s.Age >= 18 && s.Age <= 25);
            Console.WriteLine("\nAge between 18 and 25");
            foreach (var s in result1)
            {
                Console.WriteLine(s.Name +" "+s.Age);
            }

            var result3 = students.OrderByDescending(s => s.Marks);
            Console.WriteLine("\nmarks in descending");
            foreach (var s in result3)
            {
                Console.WriteLine(s.Name + " " + s.Marks);
            }

            var nameMarks = students.Select(s => new { s.Name, s.Marks });
            Console.WriteLine("\n Only name and marks printing");
            foreach (var s in nameMarks)
            {
                Console.WriteLine(s.Name + " " + s.Marks);
            }

        }
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Marks { get; set; }
            public Student(int id, string name, int age, int marks)
            {
                Id = id;
                Name = name;
                Age = age;
                Marks = marks;
            }
}        }
    }

