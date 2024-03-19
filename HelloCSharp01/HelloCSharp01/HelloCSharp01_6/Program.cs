using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp01_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for반복문으로 덧셈하기");
            int SumWithFor = 0;
            for(int i = 0; i< 101; i++)
            {
                SumWithFor += i;
            }
            Console.WriteLine(SumWithFor);

            Console.WriteLine("한글 전부 출력하기");
            for(char i = '가'; i <= '힣'; i++)
            {
                Console.Write(i);
            }

            int[] nums = { 11, 10, 59, 27, 30 };
            // nums 라는 배열 안에 있는 값들을 하나씩 item 에 집어넣어 nums의 길이만큼 반복문 수행
            // foreach(var 요소 in 컬렉션) {}, 컬렉션 = 배열, list와 같이 여러개의 값을 저장하는 것
            // java의 for(int item : nums)와 동일
            foreach(var item in nums) // var 대신 int 사용 가능
                Console.WriteLine(item);
        }
        
    }
}
