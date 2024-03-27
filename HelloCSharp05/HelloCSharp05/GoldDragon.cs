using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class GoldDragon : Dragon
    {
        public override int castMagic(string name)
        {
            Console.WriteLine("주문 없이 마법을 바로 쓴다");
            Console.WriteLine("마법 이름 : " + name);
            return 100;
        }

        public override void fly()
        {
            Console.WriteLine("날개없어도 마법으로 난다!!");
        }

        public override void polymorp(string name)
        {
            Console.WriteLine("변신: " + name);
            
        }

        public override void sayHello()
        {
            Console.WriteLine("미천한 벌레놈들");
        }
    }
}
