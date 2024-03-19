using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp01_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        StartPos:
            Console.WriteLine("숫자입력");
            int num = int.Parse(Console.ReadLine());
            if(num < 0)
            {
                goto StartPos;
            }
            Console.WriteLine("프로그램종료");
        }
    }
}
