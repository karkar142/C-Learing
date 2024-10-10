using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4Re
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Home ho = new Home() { Name = "FMI Housing", Value = 1651184944949.36M };
            //Console.WriteLine($"{ho.Name},{ho.Value}");
            //Stock st = new Stock() { Name = "Pinlone Housing", Value = 46489489446464 };
            //Console.WriteLine($"{st.Name},{st.Value}");
            //DisplayOutPut(new Home() { Name = "PinLone Housing", Value = 16546484646.32M });
            //DisplayOutPut(new Stock() { Name = "Rose Garden", Value = 1315314651232131 });

            //Stock Fmi = new Stock() { Name = "FOE Condo", Value = 44894897 };
            //Assist a=Fmi; //Child to parent (Upcast)
            //Stock b=(Stock)a; //Parent to child(DownCast)

            //Console.WriteLine(a==Fmi);
            //virtual
            //Debt debt = new Debt() { Name="AYA" ,Mortgage=4849};
            //Console.WriteLine(debt.Liablilty);

            //Stock s= new Stock() { StockPacentValue=35,StockPrice=6500};
            //Console.WriteLine(s.TotalValue);

        }

        //static void DisplayOutPut(Assist a)
        //{
        //    Console.WriteLine(a.Name);
        //}
        //abstract class Assist
        //{
        //    //public string Name { get; set; }
        //    //public virtual decimal Liablilty => 0;
        //    public abstract decimal TotalValue { get; }
        //}
        //class Home:Assist
        //{
        //    public int SquareFeet { get; set; }
        //    public decimal CurrentPrice { get; set; }
        //    public override decimal TotalValue => SquareFeet*CurrentPrice;


        //}
        //class Stock : Assist
        //{
        //    public int StockPacentValue { get; set; }
        //    public decimal StockPrice { get; set; }
        //    public override decimal TotalValue => StockPrice * StockPacentValue;
        //}
        abstract class Owner_Price
        {
            public abstract decimal Price();
        }
        
        class PurchasePrice:Owner_Price
        {
            public decimal pPrice { get; set; }
            public override decimal Price()
            {
                return pPrice;
            }
        }

        class SoldPrice:Owner_Price
        {
            public decimal sPrice { get; set; }
            public override decimal Price() { return sPrice; }
        }
        class RegularPrice:Owner_Price
        {
            public decimal reprice { get; set; }
            public override decimal Price()
            {
                return reprice;
            }
        }
        class TotalAmountCalcu
        {
            public decimal TotalAmount(Owner_Price[] items)
            {
                //SoldPrice sitems;
                //PurchasePrice pitems;
                decimal am=0;

                //foreach(var res in item)
                //{
                //    if(res is SoldPrice)
                //    {
                //        sitems= (SoldPrice)res;
                //        am += sitems.Price;
                //    }
                //    else if(res is PurchasePrice)
                //    {
                //        pitems= (PurchasePrice)res;
                //        am += pitems.Price;
                //    }
                //}

                foreach (var p in items)
                {
                    am+=p.Price();  
                }
                return am;
            }
        }
        //class Debt:Assist
        //{

        //    public decimal Mortgage;
        //    public override decimal Liablilty => Mortgage;
        //}
    }
}
