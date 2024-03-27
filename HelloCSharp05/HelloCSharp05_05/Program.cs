using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05_05
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            // 짝수만 가져오고 싶다.
            List<int> evenNum = new List<int>();
            foreach(var item in nums)
            {
                if(item % 2 == 0)
                {
                    evenNum.Add(item);
                }
            }

            // LINQ = 컬렉션(배열이나 List)에 있는 값을 SQL 형식으로 가져오는 문법
            // from 요소이름(변수이름) in 컬렉션명 where 조건 select 가져올값
            var evenNum2 = from item in nums where item % 2 == 0 select item;

            foreach (var item in evenNum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in evenNum2 )
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<int> powerNum = new List<int>();
            foreach(var item in nums)
            {
                powerNum.Add(item * item);
            }

            Console.WriteLine();

            foreach(var item in powerNum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var powerNum2 = from item in nums select item * item;
            foreach(var item in powerNum2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<int> myeven = evenNum.ToList();
            List<int> mypower = powerNum2.ToList();

            List<int> oddNum = (from item in nums where item % 2 != 0 select item).ToList<int>();
            foreach(var item in oddNum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var powerEvenOutput = from item in nums
                                  where item % 2 == 0
                                  select new
                                  {
                                      num = item,
                                      doubleNum = item * 2,
                                      powerNum = item * item // 익명객체
                                  };
            foreach(var item in powerEvenOutput)
            {
                Console.WriteLine(item.num+","+item.doubleNum+","+item.powerNum);
            }
            Console.WriteLine();

            List<Product> products = new List<Product>();
            products.Add(new Product { name = "고구마", price = 5000});
            products.Add(new Product { name = "마", price = 2500});
            products.Add(new Product { name = "당근", price = 9000});
            products.Add(new Product { name = "파", price = 500});
            products.Add(new Product { name = "감자", price = 5500});


            //LINQ의 장단점
            //장점 : for와 if없이 쉽게 값을 뽑아낼 수 있다.
            //단점 : 이 코드들이 1줄로 간주되기 떄문에 오류가 생기면 디버깅 하기 힘들다.
            var myproducts = from item in products
                             where item.price > 5000
                             orderby item.name
                             ascending
                             select item;

            List<Product> vipProducts = (from item in products
                                        where item.price > 5000
                                        orderby item.name
                                        ascending
                                        select item).ToList<Product>();

            foreach(var item in myproducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach(var item in vipProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (Product item in vipProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (Product item in myproducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
