using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meterbill_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number: ");
           xyz: int num = int.Parse(Console.ReadLine());
            int result = 0;
            int range0 = 0, range1 = 0, range2 = 0, range3 = 0, range4 = 0, range5 = 0, range6 = 0;

            if (num >= 0 && num < 26)
            {
                result = num;
                range0 = result;
                Console.WriteLine("1 to 25 :" + range0);
                Console.WriteLine("26 to 50  :" + range1);
                Console.WriteLine("51 to 100  :" + range2);
                Console.WriteLine("101 to 150 :" + range3);
                Console.WriteLine("151 to 200 :" + range4);
                Console.WriteLine("Above 201 :" + range5);
            }
            else if (num >= 26 && num < 51)
            {
                num = num - 25;
                range0 = 25;
                range1 = num;
                Console.WriteLine("1 to 25 :" + range0);
                Console.WriteLine("26 to 50  :" + range1);
                Console.WriteLine("51 to 100  :" + range2);
                Console.WriteLine("101 to 150 :" + range3);
                Console.WriteLine("151 to 200 :" + range4);
                Console.WriteLine("Above 201 :" + range5);
            }
            else if (num >= 51 && num < 101) //different 50 number
            {
                num = num - 50;
                range0 = 25;
                range1 = 25;
                range2 = num;
                Console.WriteLine("1 to 25 :" + range0);
                Console.WriteLine("26 to 50  :" + range1);
                Console.WriteLine("51 to 100  :" + range2);
                Console.WriteLine("101 to 150 :" + range3);
                Console.WriteLine("151 to 200 :" + range4);
                Console.WriteLine("Above 201 :" + range5);
            }

            else if (num >= 101 && num < 151) //different 25 number
            {
                num = num - 100;
                range0 = 25;
                range1 = 25;
                range2 = 50;
                range3 = num;
                Console.WriteLine("1 to 25 :" + range0);
                Console.WriteLine("26 to 50  :" + range1);
                Console.WriteLine("51 to 100  :" + range2);
                Console.WriteLine("101 to 150 :" + range3);
                Console.WriteLine("151 to 200 :" + range4);
                Console.WriteLine("Above 201 :" + range5);
            }

            else if (num >= 151 && num < 200)
            {
                num = num - 150;
                range0 = 25;
                range1 = 25;
                range2 = 50;
                range3 = 50;
                range4 = num;
                Console.WriteLine("1 to 25 :" + range0);
                Console.WriteLine("26 to 50  :" + range1);
                Console.WriteLine("51 to 100  :" + range2);
                Console.WriteLine("101 to 150 :" + range3);
                Console.WriteLine("151 to 200 :" + range4);
                Console.WriteLine("Above 201 :" + range5);
            }

            else
            {
                num = num - 200;
                range0 = 25;
                range1 = 25;
                range2 = 50;
                range3 = 50;
                range4 = 50;
                range5 = num;
                Console.WriteLine("1 to 25 :" + range0);
                Console.WriteLine("26 to 50  :" + range1);
                Console.WriteLine("51 to 100  :" + range2);
                Console.WriteLine("101 to 150 :" + range3);
                Console.WriteLine("151 to 200 :" + range4);
                Console.WriteLine("Above 201 :" + range5);
            }
            goto xyz;
        }
    }
}
