using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace HelloCSharp05_06
{
    public class Program
    {
        static void Main(string[] args)
        {
            //https://www.weather.go.kr/w/rss/dfs/hr1-forecast.do?zone=2714055500

            string url = "https://www.weather.go.kr/w/rss/dfs/hr1-forecast.do?zone=2714055500";
                XElement x = XElement.Load(url); // url 사이트에 있는 xml 문서를 불러 옴
            var xq = from item in x.Descendants("data") select item;
            foreach(var item in xq)
            {
                Console.WriteLine(item);
            }

            foreach(var item in xq)
            {
                Console.WriteLine("시간: " +item.Element("hour").Value);
                Console.WriteLine("온도: " +item.Element("temp").Value);
                Console.WriteLine("날씨: "+item.Element("wfKor").Value);
            }
            Console.WriteLine();

            var xmlQuery = from item in x.Descendants("data") select new
            {
                Hour = item.Element("hour").Value,
                Temp = item.Element("temp").Value,
                wfKor = item.Element("wfKor").Value
            };
            Console.WriteLine();
            foreach (var item in xmlQuery)
            {
                Console.WriteLine("시간: " + item.Hour);
                Console.WriteLine("온도: " + item.Temp);
                Console.WriteLine("날씨: " + item.wfKor);
            }
            


        }
     }
}
