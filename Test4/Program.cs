using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
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
            List<Student> sl = new List<Student>();
           z: Console.WriteLine("Choose 1 for stop:  2 for Continue:");
            int flag=int.Parse(Console.ReadLine());
            if(flag==1 || flag ==2)
            {
                if(flag==2)
                {
                    Student stu = new Student();
                    Console.Write("Enter Name: ");
                    stu.Name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    stu.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Town: ");
                    stu.Town = Console.ReadLine();
                   // sl.Add(stu);
                   Program p = new Program();
                    sl.Add( p.InsertStudent(stu));
                    //var ret=p.InsertStudent(stu);
                    //foreach(var obj in ret)
                    //{
                    //    sl.Add(obj);
                    //}

                    goto z;
                }
               
            }
            else
            {
                Console.WriteLine("Wrong Input>:");
            }
            Program p1 = new Program();
            //p1.GetAllStudent(sl);
            p1.GetAllStudentByLINQ(sl);

            Console.WriteLine("");
            //fluent, Query
            //var resdata=(from a in sl where a.Name.Length>=4 select a).ToList();
            //var resdata=sl.Select(a=> a.Name).Where(b=>b.Length>=4).ToList();
            //foreach(var res in resdata)
            //{
            //    Console.WriteLine($"{res}");
            //}

        }
        Student InsertStudent(Student s)
        {
            //List<Student>lst= new List<Student>();
            //lst.Add(s);
            return s;
        }
        void GetAllStudentByLINQ(List<Student> lst)
        {
            //var nl=lst.Select(a=>a.Name).ToList();
            //var len=nl.Where(b=>b.Length>=4).ToList();
            var resdata =lst.Select(a=>a.Name).Where(b=>b.Length>=4).Take(3).OrderBy(c=>c);

            foreach(var res in resdata)
            {
                Console.WriteLine($"{res}");
            }
        }
        void GetAllStudent(List<Student> lst)
        {
            foreach (Student res in lst)
            {
                Console.WriteLine($"{res.Name} , {res.Age} , {res.Town} ");
            }
        }
    }
}
