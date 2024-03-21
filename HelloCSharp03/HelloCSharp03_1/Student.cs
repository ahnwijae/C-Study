using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03_1
{
    public struct Student // struct != class
    {// 복사하는 방식이 값 복사 방식을 쓴다.
        public string name { get; set; }
        public int age { get; set; }
        public int score { get; set; }

    }
}
