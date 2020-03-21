using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstChapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Hello";
            //var textItem = text[0];
            //Console.WriteLine(textItem);
            Location a = new Location(20, 20);
            Location b = a;
            a.x = 100;
            Console.WriteLine(b.x);

            LocationClass l = new LocationClass(20, 20);
            LocationClass m = l;
            l.x = 100;
            Console.WriteLine(m.x);
            Console.ReadLine();
        }
    }
}
