using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp04_031
{
    // 두 개의 Product를 비교할 때 가격을 기준으로 비교
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo(((Product)obj).Price); // price를 기준으로 정렬
        }

        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString() // Object의 ToString을 오버라이드
        {
            return Name + " : " + Price + "원";
        }
    }
}
