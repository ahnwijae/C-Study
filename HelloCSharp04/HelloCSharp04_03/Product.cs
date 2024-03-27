using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp04_03
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo(((Product)obj).Price); // price를 기준으로 정렬
        }

        public override string ToString() // Object의 ToString을 오버라이드
        {
            return Name + " : " + Price + "원";
        }
    }
}
