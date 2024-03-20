using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp01_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //개미수열
            string start = "1";
            int choose = int.Parse(Console.ReadLine());
            for(int i = 0; i<choose; i++) 
            {
                Console.WriteLine(i+1+"번째 수열:" + start);
                char num = start[0]; // 읽은 숫자
                string end = ""; // 읽고 말하기 누적용 변수
                int count = 0; // 읽은 숫자의 개수
                for(int j = 0; j<start.Length; j++) 
                {
                    if (start[j] == num)
                    {
                        count++;
                    }
                    else
                    {
                        end = end+num+count;
                        num = start[j];
                        count = 1;
                    }
                }
                end = end + num + count;
                start = end;
            }
        }
    }
}
