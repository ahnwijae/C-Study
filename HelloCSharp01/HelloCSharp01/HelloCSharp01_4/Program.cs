using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp01_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 년도를 입력하세요");
            int year = int.Parse(Console.ReadLine());
            int nowyear = DateTime.Now.Year;
            if (year % 12 == 0)
            {
                Console.WriteLine("쥐띠");
            }
            else if (year % 12 == 11)
            {
                Console.WriteLine("소띠");
            }
            else if (year % 12 == 10)
            {
                Console.WriteLine("호랑이띠");
            }
            else if (year % 12 == 9)
            {
                Console.WriteLine("토끼띠");
            }
            else if (year % 12 == 8)
            {
                Console.WriteLine("용띠");
            }
            else if (year % 12 == 7)
            {
                Console.WriteLine("뱀띠");
            }
            else if (year % 12 == 6) 
            {
                Console.WriteLine("말띠");
            }
            else if (year % 12 == 5)
            {
                Console.WriteLine("양띠");
            }
            else if (year % 12 == 4)
            {
                Console.WriteLine("원숭이띠");
            }
            else if(year % 12 == 3)
            {
                Console.WriteLine("닭띠");
            }
            else if (year % 12 == 2)
            {
                Console.WriteLine("개띠");
            }
            else if(year % 12 == 1)
            {
                Console.WriteLine("돼지띠");
            }

            Console.WriteLine("현재 년도에 해당하는 띠 구하기");
            Console.WriteLine("현재 년도를 입력하세요");
            int nowyear = int.Parse(Console.ReadLine());
            switch (nowyear % 12)
            {
                case 0:
                    Console.WriteLine("쥐띠");
                    break;
                case 1:
                    Console.WriteLine("돼지띠");
                    break;
                case 2:
                    Console.WriteLine("개띠");
                    break;
                case 3:
                    Console.WriteLine("닭띠");
                    break;
                case 4:
                    Console.WriteLine("원숭이띠");
                    break;
                case 5:
                    Console.WriteLine("양띠");
                    break;
                case 6:
                    Console.WriteLine("말띠");
                    break;
                case 7:
                    Console.WriteLine("뱀띠");
                    break;
                case 8:
                    Console.WriteLine("용띠");
                    break;
                case 9:
                    Console.WriteLine("토끼띠");
                    break;
                case 10:
                    Console.WriteLine("호랑이띠");
                    break;
                case 11:
                    Console.WriteLine("소띠");
                    break;
            }
            Console.WriteLine("현재 월을 입력하세요");
            int month = int.Parse(Console.ReadLine());
            if(month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("겨울");
            }
            else if(month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("봄");
            }
            else if(month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("여름");
            }
            else
            {
                Console.WriteLine("가을");
            }

        }
    }
}
