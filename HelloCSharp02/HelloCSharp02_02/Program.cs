using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp02_02
{
    internal class Program
    {
        // static이 붙어잇는 메소드 안에는 static이 붙은 메소드나 변수만 사용 가능
        // static이 붙어있지 않으면 사용 불가
        static void HelloWorld()
        {
        Console.WriteLine("hello world");
        }
        void HiWorld()
        {
            Console.WriteLine("hi world");
        }
        static int count  = 0;
        int number = 0;
        static void Main(string[] args)
        {
            HelloWorld();
            //HiWorld();
            // static이 붙은 helloworld는 메모리에 먼저 저장이 되지만
            // hiworld는 메모리에 저장이 되지않아 아직 존재하지 않는 것
            Console.WriteLine(count);
            //Console.WriteLine(number);
            //변수도 동일

            // 굳이 static 없는 걸 main에서 쓰고싶다면
            // 자기 자신을 객체화 해야함
            new Program().HiWorld();
            // 이렇게 하면 메모리 할당


            Product p1 = new Product();
            p1.name = "감자";
            p1.price = 1000;
            Product.countOfProduct++;

            Product p2 = new Product() { name = "당근", price = 1000 };
            Product.countOfProduct++;

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.price);
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.price);
            Console.WriteLine(Product.countOfProduct);
        }
    }
}
