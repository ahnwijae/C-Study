using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03
{
    internal class Program
    {
        static void change(int input)
        {
            input++;
        }
        static void change(Student student)
        {
            student.name = "이주섭";
            student.score = 90;
            student.age = 20;
        }
        // ref = 참조자
        // 메소드 안에서 값이 바뀌면 원본도 같이 바뀜
        static void change(ref int input)
        {
            input++;
        }
        // 클래스 말고 배열, List도 똑같이 참조 복사 개념 적용 됨
        // 구조체(Struct)는 일반 자료형처럼 값 복사 개념 적용 됨
        static void Main(string[] args)
        {
            // ---------값 복사
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            // 서로 영향을 받지 않는다.
            change(a);
            Console.WriteLine("a="+a);
            // input 과 a도 별개

            
            // -----------참조 복사
            Student s = new Student();
            s.name = "권성직";
            s.age = 30;
            s.score = 100;
            Student s2 = new Student();
            s2.name = "이유탁";
            s2.age = s.age;
            s2.score = 80;
            Console.WriteLine(s.name + "," + s.age + "," + s.score);
            Console.WriteLine(s2.name + "," + s2.age + "," + s2.score);
            Console.WriteLine();
            Student dj = s;
            dj.score = 0;
            dj.name = "이동준";
            
            Console.WriteLine(s.name+","+s.age+","+s.score);
            Console.WriteLine(dj.name+","+dj.age+","+dj.score);

            change(dj);
            Console.WriteLine(dj.name + "," + dj.age + "," + dj.score);
            Console.WriteLine(s.name + "," + s.age + "," + s.score);

            // art 방향키 => 코드 옮기기
            Console.WriteLine("a="+a);
            change(ref a);
            Console.WriteLine("a="+a);
            
        }
    }
}
