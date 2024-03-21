using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03_1
{
    internal class Program
    {
        static void change(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
        static void change(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a=" + a + ", b=" + b);
        }
        static void change(Student student)
        {
            student.name = "안위재";
            student.age = 40;
            student.score = 75;
            // 이 함수가 끝나면 사라지는 값
            // 원본에 영향X
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a=" + a + ", b=" + b);
            change(ref a, ref b);
            Console.WriteLine("a=" + a + ", b=" + b);
            change(a, b);
            Console.WriteLine("a=" + a + ", b=" + b);

            // student가 클래스가 아닌 구조체이기 때문에 값을 덮어쓰지 않는다.
            Student s = new Student();
            s.age = 30;
            s.name = "권성직";
            s.score = 100;
            Student dj = s;
            dj.score = 0;
            dj.name = "이동준";
            Console.WriteLine(s.name+","+s.age+","+s.score);
            Console.WriteLine(dj.name+","+dj.age+","+dj.score);
            change(dj);
            Console.WriteLine(dj.name+","+dj.age+","+dj.score);
        }
    }
}
