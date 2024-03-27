using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Cat : Animal
    {
        public override void cry()
        {
            Console.WriteLine("냥냥냥");
        }

        public override void eat()
        {
            Console.WriteLine("냠냠냠");
        }

        public override void sleep()
        {
            Console.WriteLine("쿨쿨쿨");
        }
    }
}
