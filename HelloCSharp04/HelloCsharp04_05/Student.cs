using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCsharp04_05
{

    // datagridview 바인딩 하기 전 반드시 해야 할 것
    // 1. 한 번 실행을 하고 나서 바인딩 한다.
    // 2. 빌드 -> 솔루션 정리, 솔루션 빌드, 솔루션 다시 빌드 누르고 바인딩한다.
    public class Student
    {
        public string hakbeon { get; set; }
        public string name { get; set; }
        public int age; // 이건 datagridview 에 안나옴
    }
}
