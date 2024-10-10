using Day3_CRUDEX.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CRUDEX
{
    public class Program
    {
        void BindData()
        {
            List<tbl_STUR>list= new List<tbl_STUR>();
            using (F9DbContentDataContext db = new F9DbContentDataContext())
            {
                list=db.tbl_STURs.ToList();
            }
            foreach (var s in list)
            {
                Console.WriteLine($"{s.StudentID} , {s.Name} , {s.Age} , {s.Email} , {s.Phone} ");
            }
        }
        void BindDataByID(string Id)
        {
            tbl_STUR obj = new tbl_STUR();
            using(F9DbContentDataContext db = new F9DbContentDataContext())
            {
                 obj = db.tbl_STURs.Where(v => v.StudentID == Id).FirstOrDefault();
            }
            Console.WriteLine($"{obj.StudentID},{obj.Name},{obj.Email},{obj.Phone}");
        }
        static void Main(string[] args)
        {
           xy: Console.WriteLine("Choose 1 for Insert: 2 for Delect: 3 for update : 4 for BinDataByID: ");
            int ch=int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine("Enter Name: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                string Age = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter Phone Number: ");
                string Phone = Console.ReadLine();

                Guid Id = Guid.NewGuid();
                using (F9DbContentDataContext db = new F9DbContentDataContext())
                {
                    tbl_STUR lis = new tbl_STUR();
                    lis.StudentID = Id.ToString();
                    lis.Name = Name;
                    lis.Age = Age;
                    lis.Email = Email;
                    lis.Phone = Phone;

                    //save on databse
                    db.tbl_STURs.InsertOnSubmit(lis);
                    db.SubmitChanges();

                    Program a = new Program();
                    a.BindData();
                    goto xy;
                }

            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter StudentID: ");
                string Id = Console.ReadLine();

                using (F9DbContentDataContext db = new F9DbContentDataContext())
                {
                    var obj = db.tbl_STURs.Where(v => v.StudentID == Id).FirstOrDefault();
                    if (obj != null)
                    {
                        Console.WriteLine("Are you sure want to delete..!");
                        Console.WriteLine("Choose 1 for delete : 2 for cancel:");
                        int co = int.Parse(Console.ReadLine());

                        if (co == 1)
                        {
                            db.tbl_STURs.DeleteOnSubmit(obj);
                            db.SubmitChanges();
                            Program a = new Program();
                            a.BindData();
                            goto xy;
                        }
                        else if (co == 2)
                        {
                            goto xy;
                        }
                    }
                }
            }
            else if (ch == 3) {
                Console.WriteLine("Student Update");
                Console.WriteLine("Enter StudentID: ");
                string Id = Console.ReadLine();
                Console.WriteLine("Enter New Name: ");
                string Nm = Console.ReadLine();
                Console.WriteLine("Enter New Age: ");
                string NAge = Console.ReadLine();
                Console.WriteLine("Enter New Email: ");
                string NEmail = Console.ReadLine();
                Console.WriteLine("Enter New Phone: ");
                string NPhone = Console.ReadLine();
                
                tbl_STUR obj= new tbl_STUR();
                using (F9DbContentDataContext db = new F9DbContentDataContext())
                {
                    obj = db.tbl_STURs.Where(b => b.StudentID == Id).FirstOrDefault();
                    if (obj != null)
                    {
                        if (!string.IsNullOrWhiteSpace(Nm))
                        {
                            obj.Name = Nm;
                        }
                        if (!string.IsNullOrWhiteSpace(NAge))
                        {
                            obj.Age = NAge;
                        }
                        if (!string.IsNullOrWhiteSpace(NEmail))
                        {
                            obj.Email = NEmail;
                        }
                        if (!string.IsNullOrWhiteSpace(NPhone))
                        {
                            obj.Phone = NPhone;
                        }
                        db.SubmitChanges();
                        Program a=new Program();
                        a.BindData();
                        goto xy;
                    }
                    else{
                        Console.WriteLine("Not Found");
                    }

                }
            }
            else if (ch == 4)
            {
                Console.WriteLine("Enter StudentID: ");
                string ci= Console.ReadLine();

                Program a= new Program();
                a.BindDataByID(ci);
                goto xy;
            }
        }
    }
}
