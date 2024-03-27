using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    // 추상 클래스 : 구체적이지 않은 클래스
    // 오버라이드로 구현해야 하는 메소드 추가
    // 동물들은 자는 것, 먹는 것, 우는 것이 다 다를것
    // 그 부분을 추상메소드로 만들어 상속후 정의
    public abstract class Animal
    {
        public string name {  get; set; }
        public string description { get; set; }
        public abstract void sleep();
        public abstract void eat();
        public abstract void cry();
    }
}
