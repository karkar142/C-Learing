using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Ex
{
    internal class Program
    {
        delegate int Exchange(int x);
        static void Main(string[] args)
        {
            //Exchange e = UsdToMMK;
            //Console.WriteLine(e(3));

            Exchange e = new Exchange(UsdToMMK);
            Console.WriteLine(e.Invoke(3));
        }
        static int UsdToMMK(int usd)
        {
            return usd * 3000;
        }
    }
}
