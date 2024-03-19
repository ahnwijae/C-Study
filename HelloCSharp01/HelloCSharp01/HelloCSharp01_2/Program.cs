using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp01_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 35;
            double b = 3.14;
            char c = 'A';
            String d = "이동준"; //string 과 String 동일함
            string d2 = "이유나";
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("Text 입력");
            String text = Console.ReadLine();
            Console.WriteLine("정수 입력");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num+num);//숫자끼리 덧셈
            Console.WriteLine(text+num);//글자 이어붙이기
            */

            Console.WriteLine("inch를 입력하세요");
            int inch = int.Parse(Console.ReadLine());
            double cm = 2.54;
            Console.WriteLine(inch + "inch = " + inch * cm + "cm 입니다.");
            Console.WriteLine($"{inch}inch = {inch*cm}cm 입니다.");

            Console.WriteLine("kg을 입력하세요");
            int kg = int.Parse(Console.ReadLine());
            double pound = 2.20462262;
            Console.WriteLine(kg + "kg = " + kg * pound + "pound 입니다.");
            Console.WriteLine($"{kg}kg = {kg*pound}pound 입니다.");

            Console.WriteLine("반지름을 입력하세요");
            double r = double.Parse(Console.ReadLine());
            double PI = 3.14;
            double g = 2 * PI * r;
            double h = PI * r * r;
            Console.WriteLine("반지름 = " + r);
            Console.WriteLine("둘레 = " + g);
            Console.WriteLine("넓이 = " + h);
            Console.WriteLine($"둘레 = {2*PI*r}");
            Console.WriteLine($"넓이 = {PI * r * r}");


            //선생님답
            Console.WriteLine("Inch 단위 정수입력");
            int inch2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inch2}inch = {inch2*2.54}cm");
            Console.WriteLine(inch2+"inch="+(inch2*2.54)+"cm");
            Console.WriteLine(string.Format("{0}inch={1}cm",inch2,inch2*2.54));
            // 주의사항
            Console.WriteLine(10+2+"100"); // 12100
            Console.WriteLine(10+"100"+2); // 101002
            Console.WriteLine(10+2+"100"+2+4); // 1210024
            // 문자열 앞의 정수는 덧셈, 이후 글자 이어 붙이기가 됨
            // 먼저 더해야 하거나 연산 순서가 애매하면 무조건 괄호로 묶을 것 ex(inch2*2.54)

            Console.WriteLine("몇 kg?");
            //int.Parse("123") -> 123, 문자열을 정수로 바꿔주는 함수 
            int kg2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{kg2}kg = {2.20462262*kg2}pound");

            Console.WriteLine("원의 반지름 입력");
            const double PI2 = 3.14; // java의 final, 즉 상수
            // 상수는 대문자로 적어주는 것이 일반적
            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("둘레:" + (2 * PI2 * r2));
            Console.WriteLine("넓이:" + (r2 * r2 * PI2));
        }
    }
}
