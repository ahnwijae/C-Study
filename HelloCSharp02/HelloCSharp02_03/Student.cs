using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp02_03
{
    // internal과 public의 차이가 존재
    // internal로 써져있어 안되는 부분이 public일시 됨
    public class Student
    {
        public String name { get; set; }
        public int grade {  get; set; }
    }
}
