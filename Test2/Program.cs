using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Program
    {
        static void Main()
        {


            // Lengthby(); 
            CallTest2();

        }
        public static void CallTest2()
        {
        x: Console.WriteLine("Choose 1 for Start : 2 for End:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Which Letter do you want?:");
                char cha = char.Parse(Console.ReadLine());
                cha = char.ToLower(cha);
                Program p = new Program();
                p.Startby(cha);
            }
            else if (num == 2)
            {
                Console.WriteLine("Which Letter do you want?:");
                char cha = char.Parse(Console.ReadLine());
                cha = char.ToLower(cha);
                Endby(cha);
            }
            else
            {
                Console.WriteLine("Wrong input:>");
            }
            goto x;

        }
        List<string> Citylist()
        {
            List<string> City = new List<string>();
            City.Add("Yangon");
            City.Add("Mandalay");
            City.Add("Bago");
            City.Add("Monywar");
            City.Add("Taunggyi");
            City.Add("Pyawbwe");
            City.Add("Naypyitaw");
            City.Add("Meiktila");
            City.Add("Sagaing");
            return City;
        }

        void Startby(char c)
        {
            Program p = new Program();
            foreach (string s in p.Citylist())
            {
                if (char.ToLower(s[0]) == c)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void Endby(char c)
        {
            Program p = new Program();
            foreach (string s in p.Citylist())
            {
                int len = s.Length;
                if (char.ToLower(s[len - 1]) == c)
                {
                    Console.WriteLine(s);
                }
            }
        }

        //------Test With Call Length______
        //static void Lengthby()
        //{
        //    Program p=new Program();
        //  xyz: Console.WriteLine("_______With lenght_________-");
        //    Console.WriteLine("Input Char number:");
        //    int cm = int.Parse(Console.ReadLine());

        //    foreach (string s in p.Citylist())
        //    {
        //        if (s.Length > cm && s.Length<0)
        //        {
        //            Console.WriteLine(s);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Error..!");
        //        }
        //    }
        //    goto xyz;
        //}
    }
}
