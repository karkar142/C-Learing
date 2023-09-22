using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test2.Program.CallTest2();
            Console.WriteLine("****Check Vowel***");
            Console.WriteLine("Enter char:");
            xyz: string a= Console.ReadLine().ToLower();
            char ch=char.Parse(a);

            //if (ch =='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u') 
            //{
            //    Console.WriteLine("Vowel");
            // }
            //else
            //{
            //    Console.WriteLine("NOt Vowel");
            //}
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':Console.WriteLine("Vowel");break;
                default: Console.WriteLine("Not Vowel");break;
            }
            goto xyz;

        }
    }
}
