using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_3Exercies.DB;

namespace Day_3Exercies
{
    internal class Program
    {
        void BindData()
        {
            List<Tbl_Expense>list = new List<Tbl_Expense>();
            using(F9ExDataContext db=new F9ExDataContext())
            {
                list=db.Tbl_Expenses.ToList();
            }
            foreach(var s in list)
            {
                Console.WriteLine($"{s.Expense_Id} , {s.DateTime} , {s.Amount} , {s.Description}");
            }
        }
        void BindDataByID(string id)
        {
            Tbl_Expense tbl=new Tbl_Expense();
            using(F9ExDataContext db=new F9ExDataContext())
            {
                tbl=db.Tbl_Expenses.Where(v=> v.Expense_Id==id).FirstOrDefault();
            }
            Console.WriteLine($"{tbl.Expense_Id} , {tbl.DateTime} , {tbl.Amount} , {tbl.Description}");
        }
        void BindDataByAmount(decimal amount)
        {
            Tbl_Expense tbl = new Tbl_Expense();
            using (F9ExDataContext db = new F9ExDataContext())
            {
                tbl = db.Tbl_Expenses.Where(v => v.Amount==amount).FirstOrDefault();
            }
            Console.WriteLine($"{tbl.Expense_Id} , {tbl.DateTime} , {tbl.Amount} , {tbl.Description}");
        }
        static void Main(string[] args)
        {
            Xy: Console.WriteLine("Choose 1 for Insert : 2 for Update : 3 for Delect : 4 for BinDataById : 5 for BDataByAmount : ");
            int cho = int.Parse(Console.ReadLine());
            //Insert
            if (cho == 1)
            {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine("Enter Amount : ");
                Decimal Amount = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Entre Description :");
                string des = Console.ReadLine();

                Guid Id = Guid.NewGuid();

                // List<Tbl_Expense> list=new List<Tbl_Expense>();

                using (F9ExDataContext db = new F9ExDataContext())
                {
                    Tbl_Expense tbl = new Tbl_Expense();
                    tbl.Expense_Id = Id.ToString();
                    tbl.DateTime = dateTime;
                    tbl.Amount = Amount;
                    tbl.Description = des;

                    db.Tbl_Expenses.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                    Program a = new Program();
                    a.BindData();
                    goto Xy;
                }

            }
            //Update

            else if (cho == 2)
            {
                
                Console.WriteLine("Enter ExpendID : ");
                string id = Console.ReadLine();
                Console.WriteLine("Enter New Description : ");
                string Dc = Console.ReadLine();
                Console.WriteLine("Enter new amount : ");
                //string amt= Console.ReadLine();
                //amt = amt.Substring(0, 18); 
                //decimal amount = Decimal.Parse(amt);

               // System.Diagnostics.Debugger.Launch();
                Tbl_Expense tbl = new Tbl_Expense();
                using (F9ExDataContext db = new F9ExDataContext())
                {
                    if (tbl != null)
                    {
                        tbl = db.Tbl_Expenses.Where(b => b.Expense_Id == id).FirstOrDefault();
                        tbl.DateTime = DateTime.Now;

                        if (!string.IsNullOrEmpty(Dc))
                        {
                            tbl.Description = Dc;
                        }
                        //need to repair code here
                        decimal amount;
                        string amt = Console.ReadLine();
                        if (!string.IsNullOrEmpty(amt))
                        {
                            amount = decimal.Parse(amt);
                            tbl.Amount = amount;
                        }
                        //tbl.Amount = amount;

                        db.SubmitChanges();
                        Program a = new Program();
                        a.BindData();
                        goto Xy;
                    }
                    else
                    {
                        Console.WriteLine("Not Found ");
                    }
                }

            }
            //Delect
            else if (cho == 3)
            {
                Console.WriteLine("Enter expense ID: ");
                string id = Console.ReadLine();

                using (F9ExDataContext db = new F9ExDataContext())
                {
                    var obj = db.Tbl_Expenses.Where(c => c.Expense_Id == id).FirstOrDefault();
                    if (obj != null)
                    {
                        Console.WriteLine("Choose 1 for Are you sure want to delect..? or 2 for cancel delect .");
                        int ch = int.Parse(Console.ReadLine());
                        if (ch == 1)
                        {
                            db.Tbl_Expenses.DeleteOnSubmit(obj);
                            db.SubmitChanges();
                            Program a = new Program();
                            a.BindData();
                            goto Xy;
                        }
                        else
                        {
                            goto Xy;
                        }
                    }
                }
            }
            //Bindatabyid
            else if (cho == 4)
            {
                Console.WriteLine("Enter ExpenseID : ");
                string id = Console.ReadLine();
                Program s = new Program();
                s.BindDataByID(id);
                goto Xy;
            }
            else if (cho == 5)
            {
                Console.WriteLine("Enter Amount : ");
                decimal amount = decimal.Parse(Console.ReadLine());

                Program a = new Program();
                a.BindDataByAmount(amount);
                goto Xy;
            }
        }
    }
}
