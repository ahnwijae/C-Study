using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05_01
{
    public class Program
    {

        delegate void voidFunc();

        static void testMethod()
        {
            Console.WriteLine("test~~~~~~");
        }
        static void doFunc(voidFunc v, int count)
        {
            for(int i = 0; i < count; i++)
            {
                v();
            }
        }
        static void Main(string[] args)
        {
            testMethod();
            doFunc(testMethod, 3);// testMethod를 세번 호출
            doFunc(delegate () { Console.WriteLine("-----"); },3 ); // 무명 델리게이트
            doFunc(() => { Console.WriteLine("------"); },3 ); // 람다식

            voidFunc v1 = delegate () { Console.WriteLine("하이"); };
            voidFunc v2 = () => { Console.WriteLine("ㅎㅇ"); };

            doFunc(v1, 5);
            doFunc(v2, 5);

        }
    }
}
