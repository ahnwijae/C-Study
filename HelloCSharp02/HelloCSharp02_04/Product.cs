using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp02_04
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }

        // 접근 제한자 없으면 private이 기본
        // private은 해당 클래스 안에서만 접근가능
        string description { get; set; }

        private int vipPrice { get; set; }

        public void setVipPrice(int vipPrice)
        {
            this.vipPrice = vipPrice;
        }
        public int getVipPrice()
        {
            return vipPrice;
        }// C#에서는 이런 방식 잘 사용하지 않음

        //아래와 같은 생성자 자동으로 생성됨
        //public Product()
       // {
//
     //   }

        // 생성자를 내가 명시하는 순간 암묵적으로 만들어진 빈 생성자가 사라짐
     public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        // 생성자 역시도 오버로딩 가능
        public Product(string name)
        {
            this.name = name;
            Console.WriteLine("가격");
        }
        // 매개변수 없는 생성자를 쓰고싶다면 만들어야함
        public Product()
        {
            Console.WriteLine("생성");
        }
    }
}
