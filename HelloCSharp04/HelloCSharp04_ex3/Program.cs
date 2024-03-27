using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp04_ex3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a = "3";
            string b = "5";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            bool fa = int.TryParse("a", out int c);
            Console.WriteLine(c);
            Console.WriteLine(fa);
            if (c == 0)
            {
                c = int.Parse(a);
                a = b;
                b = c.ToString();
            }

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
