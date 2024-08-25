using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_23._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Present pres1 = new Present();
            Present pres2 = new Present(10);
            Present pres3 = new Present(50);

            showPrice(pres1);
            showPrice(pres2);
            showPrice(pres3);
        }

        static void showPrice(Present pres)
        {
            Console.WriteLine($"Price is { (pres.price != null ? pres.price.ToString() : "not set")}");
        }

        public class Present
        {
            public int? price { get; set; }

            public Present() { }
            public Present(int price) { this.price = price; }
        }
    }
}
