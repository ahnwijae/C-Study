﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03_2
{
    internal class Program
    {
        // Dictionary 는 java의 Hashmap과 똑같다.
        static Dictionary<int,long>memo = new Dictionary<int, long>();
        static long Fibo(int i)
        {
            if(i<=0) return 0;
            if (i == 1) return 1;
            return Fibo(i - 2) + Fibo(i - 1);
        }
        static long Fibonacci(int i)
        {
            if (i <= 0) return 0;
            if (i == 1) return 1;
            if(memo.ContainsKey(i)) return memo[i];
            else
            {
                long value = Fibonacci(i - 2) + Fibonacci(i - 1);
                memo[i] = value;
                return value;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(Fibo(40)); 
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
            Console.WriteLine(Fibonacci(100));
            Console.WriteLine(DateTime.Now.ToString("mm분ss초fff"));
        }
    }
}
