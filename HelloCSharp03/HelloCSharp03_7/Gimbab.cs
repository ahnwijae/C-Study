using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03_7
{
    public class Gimbab : Food 
    {
        public override void taste() // 추상메소드라 상속받고나서 값을 줘야함
        {
            Console.WriteLine("젓가락으로 먹습니다.");
        }
        
    }
}
