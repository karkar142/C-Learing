using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_3.DB;

namespace Day_3
{
    class Program
    {
        void BindData()
        {
            List<Tbl_Country> list = new List<Tbl_Country>();

            using(F9DataContext db=new F9DataContext())
            {
                list=db.Tbl_Countries.ToList();
            }
            foreach (var s in list)
            {
                Console.WriteLine($"{s.CountryID} , {s.Country_Name} , {s.Country_Code}");
            }
        }
        void BindDataByID(string id)
        {
            Tbl_Country Tbl = new Tbl_Country();
            using (F9DataContext db = new F9DataContext())
            {
                Tbl = db.Tbl_Countries.Where(v => v.CountryID == id).FirstOrDefault();

                Console.WriteLine($"{Tbl.CountryID} , {Tbl.Country_Name} , {Tbl.Country_Code}");
            }
        }
        void BindDataByName(string Nm)
        {
            Tbl_Country tbl = new Tbl_Country();
            using(F9DataContext db= new F9DataContext())
            {
                tbl=db.Tbl_Countries.Where(a=> a.Country_Name == Nm).FirstOrDefault();
            }
            Console.WriteLine($"{tbl.CountryID} , {tbl.Country_Name} , {tbl.Country_Code}");
        }
        static void Main(string[] args)
        {
            #region Linq
            //List<string> Country = new List<string> { "Myanmar","Loas","Thiland","Singapore","India"};
            //var city = new[] { "Myanmar Yangon", "Thialand Bankok", "America Us" };
            //crosss join method
            //List<string>vs=(from c1 in Country
            //                from c2 in Country
            //                where c1.CompareTo(c2) <0
            //                select c1 +"vs" +c2).ToList();
            //foreach (string v in vs)
            //{
            //    Console.WriteLine(v);
            //}

            //var ct = (from c1 in city
            //          from c2 in c1.Split()
            //          select c2);
            //foreach (var c in ct)
            //{
            //    Console.WriteLine(c);
            //}
            //to show with index
            // var Clst=Country.Select((c,ind)=> ind + " = " + c);
            //foreach (var country in Clst)
            //{
            //    Console.WriteLine(country);
            //}
            // use selectmany
            //var ct=city.SelectMany(c=> c.Split() );
            //foreach (var c in ct)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            #endregion
            //DB
            //RDBMS , DBMS
            //ACID Properies
            //Console.WriteLine("Enter Country Name : ");
            //string cn=Console.ReadLine();
            //Console.WriteLine("Enter Country Code : ");
            //string cc=Console.ReadLine();

            //Guid id= Guid.NewGuid();
            //List<Tbl_Country> list = new List<Tbl_Country>();
            //using (F9DataContext db = new F9DataContext())
            //{
            //    Tbl_Country Cun = new Tbl_Country();
            //    Cun.CountryID = id.ToString();
            //    Cun.Country_Name = cn;
            //    Cun.Country_Code = cc;
            //    db.Tbl_Countries.InsertOnSubmit(Cun);
            //    db.SubmitChanges();

            //    //var data= db.Tbl_Countries.ToList();
            //    //var data = db.VW_GetAllCountries;
            //    var data = db.GetAllCountry();
            //    foreach (var item in data)
            //    {
            //        Tbl_Country c = new Tbl_Country();
            //        c.CountryID = item.CountryID;
            //        c.Country_Name = item.Country_Name;
            //        c.Country_Code = item.Country_Code;

            //        list.Add(c);
            //    }

            //}
            //foreach (var s in list)
            //{
            //    Console.WriteLine($"{s.Country_Name} ,{s.CountryID} , {s.Country_Code} ");
            //}

            xz: Console.WriteLine("Choose 1 for insert : 2 for update : 3 for Delect : 4 for BindDataByCountryId : 5 for BindDataByName : ");
            int cho = Convert.ToInt32(Console.ReadLine());
            //Insert
            if (cho == 1)
            {
                Console.WriteLine(" Country Registration :");
                Console.WriteLine("Enter Country Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Country Code : ");
                string Code = Console.ReadLine();

                //Guid id = new Guid();
                var id = Guid.NewGuid();

                // List<Tbl_Country> list = new List<Tbl_Country>();

                using (F9DataContext db = new F9DataContext())
                {
                    Tbl_Country Con = new Tbl_Country();
                    Con.CountryID = id.ToString();
                    Con.Country_Name = name;
                    Con.Country_Code = Code;

                    db.Tbl_Countries.InsertOnSubmit(Con);
                    db.SubmitChanges();

                    //var data = db.Tbl_Countries.ToList();
                    //foreach (var item in data)
                    //{
                    //    list.Add(item);
                    //}
                    Program p = new Program();
                    p.BindData();

                }
                goto xz;
            }
            //update
            else if (cho == 2)
            {
                Console.WriteLine("Enter Id: ");
                string id = Console.ReadLine();
                Console.WriteLine("Enter new country : ");
                string nc = Console.ReadLine();
                Console.WriteLine("Enter new code : ");
                string ncode = Console.ReadLine();

                using (F9DataContext db = new F9DataContext())
                {
                    var obj = db.Tbl_Countries.Where(a => a.CountryID == id).FirstOrDefault();

                    if (!string.IsNullOrEmpty(nc)) //vilidation 
                    {
                        obj.Country_Name = nc;
                    }
                    if (!string.IsNullOrEmpty(ncode))
                    {
                        obj.Country_Code = ncode;
                    }


                    db.SubmitChanges();

                    Program p1 = new Program();
                    p1.BindData();
                }
                goto xz;
            }
            //Delect ById
            else if (cho == 3)
            {
                Console.WriteLine("Enter Id :");
                string id = Console.ReadLine();

                if (!string.IsNullOrEmpty(id))
                {
                    using (F9DataContext db = new F9DataContext())
                    {
                        var obj = db.Tbl_Countries.Where(c => c.CountryID == id).FirstOrDefault();
                        if (obj != null)
                        {
                            db.Tbl_Countries.DeleteOnSubmit(obj);
                            db.SubmitChanges();

                            Program a = new Program();
                            a.BindData();
                        }
                        else
                        {
                            Console.WriteLine("Not Fonud");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error....! Need to input ID ..");
                }
                goto xz;
            }
            //BindDataById
            else if (cho == 4)
            {
                Console.WriteLine("Enter Id : ");
                string id = Console.ReadLine();
                if (!string.IsNullOrEmpty(id))
                {
                    Program a = new Program();
                    a.BindDataByID(id);
                    goto xz;
                }
            }
            //BindDataByName
            else if (cho == 5)
            {
                Console.WriteLine("Entry CountryName: ");
                string nm = Console.ReadLine();
                Program a = new Program();
                a.BindDataByName(nm);
                goto xz;
            }
        }
    }
}
