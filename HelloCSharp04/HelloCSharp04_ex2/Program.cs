using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HelloCSharp04_ex2
{
    public class Program
    {
        // out 키워드와 ref 키워드의 가장 큰 차이
        // out 키워드가 있는 건 대입을 꼭 해줘야 한다
        // ref는 필수가 아니다
        // out은 할당되기 전에 다른 변수에 할당할 수 없다.
        // 공통점
        // ref와 out 모두 메서드 바깥에 있는 변수랑 연결되어 있음
        static void swap(int oldx, int oldy, out int x, out int y)
        {
            x = oldx;
            y = oldy;
            int temp = x;
            x = y;
            y = temp;
        }
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            // 다음 위치 = 현재 위치 + 현재 속도
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");
            Console.WriteLine();

            int x1 = 3; int y1 = 5;
            int x2 = 3; int y2 = 5;
            // ref, out : main에 있는 변수의 값과 위치 모두 참조함

            swap(x1, y1, out x1, out y1); // out 이용
            swap(ref x2, ref y2); // ref 이용

            Console.WriteLine("x1 = "+x1+",y1 = "+y1);
            Console.WriteLine("x2 = "+x2+",y2 = "+y2);
        }
    }
}
