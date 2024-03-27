using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Bulbasaur : Animal, IPlant, IPokemon
    {
        // age 부분처럼 if 문을 한 줄로 적는 건 비권장 문법
        // 가독성이 떨어지므로 if문은 두 줄 이상으로 분리를 해주는게 좋다
        private int pokemonAge;
        public int age { get { return pokemonAge; } set { if (value < 0) pokemonAge = 0; else pokemonAge = value; }  }
        public string ability { get; set; }

        public virtual void bearFruit()
        {
            Console.WriteLine("아직 그런 거 없어요.");
        }

        public virtual void blooming()
        {
            Console.WriteLine("꽃 봉오리도 없음");
        }

        public virtual void charming()
        {
            Console.WriteLine("이상해씨는 그냥 귀여움");
        }

        public override void cry()
        {
            Console.WriteLine("씨씨씨");
        }

        public override void eat()
        {
            Console.WriteLine("덩쿨로냠냠");
        }

        public virtual void fight() // 이상해씨를 상속받을 경우 fight는 오버라이드 가능
        {
            Console.WriteLine("덩쿨채찍");
        }

        public virtual void photosynthesis() // 인터페이스에서 온 메소드
        {
            Console.WriteLine("햇빛을 흡수중");
        }

        public override void sleep() // 오버라이드 = 추상클래스에서 온 메소드
        {
            Console.WriteLine("쿨쿨쿨쿨쿨");
        }
    }
}
