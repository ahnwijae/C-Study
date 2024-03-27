using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public abstract class Reptilia : Animal
    {
        public int age { get; set; }

        public abstract void crawl(); // 기어다니다
        public abstract void creep(); // 살금살금기다
        public override void eat()
        {
            Console.WriteLine("벌레를 먹습니다");
        }
        public override void cry()
        {
            Console.WriteLine("어떻게울지?");
        }
        public override void sleep()
        {
            Console.WriteLine("습한 곳에서 잡니다");
        }
        public void grow()
        {
            Console.WriteLine("탈피중");
        }
        
    }
}
