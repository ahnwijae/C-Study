using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    public class Program
    {
        static int mypriceCompare(Product a, Product b)
        {
            return a.price.CompareTo(b.price);
        }
        // 반환형이 없고 매개변수가 Product 한개인 자료형
        delegate void printProduct(Product p);

        static void printObject(printProduct pp, Product p, int count)
        {
            for(int i = 0; i < count; i++)
            {
                pp(p);
            }
        }

        static void myproductinfo(Product p)
        {
            Console.WriteLine("제품명:"+p.name);
            Console.WriteLine("제품가격:"+p.price);
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { name = "고구마", price = 1000 });
            products.Add(new Product { name = "감자", price = 2000 });
            products.Add(new Product { name = "사과", price = 400 });

            //무명 델리게이트
            products.Sort(delegate (Product a, Product b)
            {
                return a.price.CompareTo(b.price);
            });

            //public delegate int Comparison<in T>(T x, T y);
            // Sort(Comparison<Product) com);

            //람다
            products.Sort((a, b) =>
            {
                return a.price.CompareTo(b.price);
            });

            // products.Sort((a,b) => a.price.CompareTo(b.price));

            // Product.Sort(mypriceCompare);

            foreach (Product p in products)
            {
                Console.WriteLine(p.name + ":" + p.price);
            }

            printObject(myproductinfo,products[0], 5);
            Console.WriteLine();

            printObject(delegate (Product p)
            {
                Console.WriteLine("이름:" + p.name + ", " + p.price + "원");
            }, products[0], 5);
            Console.WriteLine();

            printObject(p=> { Console.WriteLine(p.name + ",\\" + p.price); }, products[0], 5);
            Console.WriteLine();

            printProduct myp = myproductinfo;
            myp = delegate (Product p)
            {
                Console.WriteLine("이름: " + p.name + ", " + p.price + "원");
            };
            Console.WriteLine();

            myp = p => Console.WriteLine(p.name + ".\\" + p.price + "원");
            printObject(myp, products[0], 3);

        }
    }
}
