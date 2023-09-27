using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
        static void Main(string[] args)
        {
            //name ,age, town
            List<Student> sl = new List<Student>();
            Student stu = new Student();
            stu.Name= "Test";
            stu.Age = 10;
            stu.Town = "Ygn";
            sl.Add(stu);
            
            Student stu1= new Student();
            stu1.Name = "Test1";
            stu1.Age = 15;
            stu1.Town = "Ygn";
            sl.Add(stu1);

            foreach(Student s in sl)
            {
                Console.WriteLine($"{s.Name} , {s.Age} , {s.Town}");
            }
        }
    }
}
