using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp02_04
{
    internal class Program
    {
        // 오버로딩 : 매개변수의 개수나 타입 다르면 함수(메소드)의 이름이 똑같아도 다른 것으로 간주
        // 리턴 타입과는 상관이 없다.
        static void introduce(int age)
        {
            Console.WriteLine("내 나이는 " + age + "살 입니다.");
        }
        static void introduce(string name)
        {
            Console.WriteLine("내 이름은 " + name + " 입니다.");
        }
        static void introduce()
        {
            Console.WriteLine("자기 소개 메소드");
        }
        static void Main(string[] args)
        {
            introduce(35);
            introduce("이동준");
            introduce();

            Rectangle.color = "파란색";
            Rectangle rec1 = new Rectangle();
            rec1.width = 10;
            rec1.height = 5;
            Rectangle rec2 = new Rectangle();
            rec2.width = 7;
            rec2.height = 8;
            Rectangle rec3 = new Rectangle();
            Console.WriteLine("여기 있는 모든 사각형의 색 : " + Rectangle.color);
            // alt shift 화살표 위 or 아래 누르면 여러개 선택 됨
            // alt shift로 전체지정 후 // 가능
            // ctrl alt 누르고 마우스 클릭하면 여러개선택
            Console.WriteLine(rec1.getArea());
            Console.WriteLine(rec2.getArea());
            Console.WriteLine(rec3.getArea());
            Console.WriteLine(Rectangle.calcRecArea(10,24));

            // Product p1 = new Product(); // 빈 생성자 사라져서 실행되지 않음
            Product p1 = new Product("고구마" , 500);
            Console.WriteLine(p1.name + "의 가격: " + p1.price);
            Product p2 = new Product("대게");


            // private이라 접근 불가능
            // 접근하기 위해선 public 메소드가 필요
            //p2.description
            //p2.vipPrice
            // 보통 C#에선 웬만하면 public... get set을 쓴다

            p1.getVipPrice();
            //p1.get
        }
    }
}
