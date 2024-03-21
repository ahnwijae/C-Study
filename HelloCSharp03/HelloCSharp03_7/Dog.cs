using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03_7
{
    public class Dog : Animal // Animal을 상속받음
    {
        public string hairColor { get; set; }

        public void Bark()
        {
            Fight(); // Animal을 상속받았으므로 사용 가능
            Console.WriteLine("멍멍 짖는다.");
            //Run(); // Animal안에서만 호출 가능
        }

        public void Eat() // 녹색 줄(경고)가 뜸, new를 쓰라고 함(안써도 자동 적용 되기는 함)
        {
            Console.WriteLine("와구와구");
        }
        public override void Charm() // 오버라이딩
        {
            // base.Charm(); // 조상 클래스에 있는 Charm
            Console.WriteLine("꼬리를 흔든다");
        }
        public new void Cry() // 하이딩
        {
            Console.WriteLine("끼잉");
        }

    }
}
