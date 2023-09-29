using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            List<string> GroupA = new List<string>();
            GroupA.Add("Myanmar");
            GroupA.Add("Cambodia");
            GroupA.Add("Laos");
            GroupA.Add("Thiland");

            List<string> GroupB = new List<string>();
            GroupB.Add("Vitnam");
            GroupB.Add("Indonesia");
            GroupB.Add("Mylaysia");
            GroupB.Add("Singpore");

            Program p= new Program();
            p.Matchplan(GroupA);
            Console.WriteLine("__________________");
            p.Matchplan(GroupB);

            #endregion
            Console.WriteLine("__________________________");
            List<string> Country = new List<string> { "Myanmar", "Cambodia", "Laos", "Thiland" };
            List<string> vs=(from c1 in Country
                             from c2 in Country
                             where c1.CompareTo(c2) <0
                             select c1+ "VS"+ c2).ToList();
            foreach (string s in vs)
            {
                Console.WriteLine(s);
            }
                                         
        }
        void Matchplan(List<string> group)
        {
            int start = 0;
            while(start<group.Count)
            {
                for(int i=start+1; i<group.Count; i++)
                {
                    Console.WriteLine($"{group[start]} VS {group[i]}");
                }
                start++;
            }
        }
    }
}
