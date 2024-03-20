using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloCSharp01_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("삼각형 모양 피라미드 만들기");
            int floor = 5;
            for(int i = 0; i < floor; i++) 
            {
                //공백 찍는 부분
                for(int j = floor-i; j > 1; j--)
                {
                    Console.Write("@"); // 띄어쓰기 가시성을 위해 @로 대신입력
                }
                //별 찍는 부분
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("5개의 숫자 입력받은 뒤 가장 작은 수와 가장 큰 수 출력하기");
            Console.WriteLine("숫자를 5개 입력해 주세요");
            int[] numbers = new int[5];
            for(int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(i + "번째 값 입력");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //가장 첫번째 값이 최댓값, 최솟값
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(max < numbers[i]) // if if if는 모든 조건문 체크
                    max = numbers[i]; // if elseif elseif else는 if가 참이면 밑에 체크 안함
                if(min > numbers[i])
                    min = numbers[i];
            }
            Console.WriteLine($"가장 큰 수 : {max}, 가장 작은 수 : {min}");
            Console.WriteLine();
            Console.WriteLine();
            

            Console.WriteLine("이 규칙을 따르는 수열의 20번째 숫자를 프로그램으로 만들어 찾기");
            Console.WriteLine("1, 11, 12, 1121, 122111, 112213");
            Console.WriteLine("첫 번째 수열 : 1");
            Console.WriteLine("두 번째 수열 : 1이 1개 = 11");
            Console.WriteLine("세 번째 수열 : 1이 2개 = 12");
            Console.WriteLine("네 번째 수열: 1이 1개, 2가 1개 = 1121");
            Console.WriteLine("다섯 번째 수열 : 1이 2개, 2가 1개, 1이 1개 = 122111");
            Console.WriteLine("여섯 번째 수열 : 1이 1개, 2가 2개, 1이 3개 = 112213");
            Console.WriteLine("일곱 번째 수열 : 1이 2개, 2가 2개, 1이 1개 3이 1개 = 12221131");
            Console.WriteLine("여덟 번째 수열 : 1이 1개, 2가 3개, 1이 2개 3이 1개 1이 1개= 1123123111");

            String[] a = new string[20];
            a[0] = "1";
            int oneCount = 0;
            int twoCount = 0;
            int threeCount = 0;
            for (int i = 1; i < 20; i++)
            {
                foreach (String s in a)
                {
                    if (s == "1")
                    {
                        oneCount++;
                    }
                    else if (s == "2")
                    {
                        twoCount++;
                    }
                    else if (s == "3")
                    {
                        threeCount++;
                    }
                }
                if(oneCount != 0 &&twoCount == 0 && threeCount == 0)
                {
                    a[i ] = "1" + oneCount;
                    Console.WriteLine(a[i]);
                }
                else if(oneCount != 0 && twoCount != 0 && threeCount == 0)
                {
                    a[i ] = "1" + oneCount + "2" + twoCount;
                    Console.WriteLine(a[i]);
                }
                else if(oneCount != 0 && twoCount != 0 && threeCount != 0)
                {
                    a[i ] = "1" + oneCount + "2" + twoCount +"3" + threeCount;
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine(a[19]);
        }
     }
 }
