using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Basics
    {
        public static void Main(string[] args)
        {
            //int n = 10;
            //int i = 20;
            //Console.WriteLine(n + i);

            //Sum of numbers in range
            //int n = Convert.ToInt32((Console.ReadLine()));
            //int n1=Convert.ToInt32((Console.ReadLine())),sum=0;
            //for(int i = n; i <= n1; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            int n =Convert.ToInt32(Console.ReadLine());
            int n1=Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for(int i = n; i <= n1; i++)
            {
                if (c == 0)
                {
                    Console.Write(i);
                    c++;
                }
                else
                    Console.Write(", "+i);
            }

        }
    }
}
