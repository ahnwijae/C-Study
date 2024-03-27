using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    // Animal 상속 받아서 sleep, cry, eat을 반드시 구현해야 함
    public class Dog : Animal
    {
        public override void cry()
        {
            Console.WriteLine("멍멍멍");
        }

        public override void eat()
        {
            Console.WriteLine("촵촵촵");
        }

        public override void sleep()
        {
            Console.WriteLine("드르렁");
        }
    }
}
