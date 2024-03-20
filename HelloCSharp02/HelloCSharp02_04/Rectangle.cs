using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp02_04
{
    public class Rectangle
    {
        public int width {  get; set; }// 각 사각형
        public int height { get; set; }// 너비, 높이 다름
        public static string color {  get; set; }// 색깔은 같음

        // getArea : 인스턴스 메소드 이므로
        // 각 인스턴스 마다 결과가 다를 수 잇음
        public int getArea()
        {
            return width * height; // 자신의 넓이
        }

        // 클래스 메소드 이므로 매개변수 따라 결과가 바뀜
        public static int calcRecArea(int w, int h)
        {
            return w * h; // 일반적인 사각형 넓이 구해주는 메소드
        }
    }
}
