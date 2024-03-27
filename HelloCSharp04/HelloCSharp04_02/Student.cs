using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp04_02
{
    // T 대신 다른 문자 넣어도 됨
    // 제네릭 문법 - 특정 속성의 타입을 정하지 못할 경우
    // 임의의 문자로 타입 지정하고 인스턴스 생성 시 타입 지정
    // 가장 대표적인 예시 List<T> - > List<int>
    // ex. Student<int> s 하면 학번은 정수
    // Student<string> s 하면 학번은 문자열
    public class Student<T>
    {
        public T hakbeon { get; set; }
        public string name { get; set; }
    }
}
