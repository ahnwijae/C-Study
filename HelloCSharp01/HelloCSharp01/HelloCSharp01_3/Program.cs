using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp01_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();  
            //rnd.Next(6) : 0~5까지의 정수가 나옴
            int num = rnd.Next(6) + 1; // 1~6까지 값 나옴
            //switch tab*2
            switch (num) 
            {
                case 1:
                case 2:
                    Console.WriteLine("1 아님 2 나옴");
                    break;
                case 3:
                    Console.WriteLine("3이 나옴");
                    break;
                case 4: // c#에서는 case 밑에 코드가 1줄이라도 있으면 break; 써야함
                    Console.WriteLine(  "4가 나옴"); // java는 break; 없어도 실행가능
                    break;
                case 5: // 밑에 코드가 없어 break;없어도 괜찮음
                case 6:
                    Console.WriteLine("5~6");
                    break;
                default:
                    break;
            }
        }
    }
}
