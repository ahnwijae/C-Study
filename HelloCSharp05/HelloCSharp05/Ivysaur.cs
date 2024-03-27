using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Ivysaur : Bulbasaur
    {
        public override void cry()
        {
            Console.WriteLine("풀풀풀풀");
        }
        public override void fight() // 이상해씨의 fight에 virtual 붙여 오버라이드 가능
        {
            Console.WriteLine("풀잎 날리기");
        }
    }
}
