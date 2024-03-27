using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Chameleon : Reptilia
    {
        public string color { get; set; }
        public void changeColor(string color)
        {
            if(color.Equals("투명색"))
            {
                this.color = "초록색";
            }
            else if(color.Equals("디지털"))
            {
                this.color = "군인인가";
            }
            else
            this.color = color;
        }
        public override void crawl()
        {
            Console.WriteLine("기어다니며 움직인다");
        }

        public override void creep()
        {
            Console.WriteLine("먹이를 보고 슬금슬금 움직인다!");
        }
        public override void cry()
        {
            Console.WriteLine("울지않아요");
        }
    }
}
