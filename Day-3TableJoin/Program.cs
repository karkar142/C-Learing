using Day_3TableJoin.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3TableJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tbl_Division division = new tbl_Division();
            Console.WriteLine("Enter Division Name:");
            division.DivisionName=Console.ReadLine();
            Console.WriteLine("Enter PostelCode:");
            division.PostelCode = Console.ReadLine();
            Console.WriteLine("Choose CountryID:");
            division.CountryID = Console.ReadLine();  
            division.DivisionID=Guid.NewGuid().ToString();

            using(F9DBDataContext Db=new F9DBDataContext())
            {
                 try
                {
                    Db.tbl_Divisions.InsertOnSubmit(division);
                    Db.SubmitChanges();
                    Console.WriteLine("Sucess save");
                    BindData();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Fail by" + ex.Message);
                }
            }
        }
        static void BindData()
        {
            using (F9DBDataContext db = new F9DBDataContext())
            {
                var obj = db.tbl_Divisions.Join(db.Tbl_Countries, d => d.CountryID, c => c.CountryID,
                (d, c) => new { d, c });

                foreach (var item in obj)
                {
                    Console.WriteLine($"{item.d.DivisionName},{item.d.PostelCode},{item.c.Country_Code},{item.c.Country_Name}");
                }
            }   }
    }
}
