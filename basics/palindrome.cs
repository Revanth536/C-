using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Palind
    {
        public static void Main(String[] args)
        {
            int p=Convert.ToInt32( Console.ReadLine() );
            int p2 = Convert.ToInt32(Console.ReadLine());

            //int t = p, rev = 0;
            //while (p > 0)
            //{
            //    int r = p % 10;
            //    rev = rev * 10 + r;
            //    p /= 10;
            //}
            //Console.WriteLine(t + " " + rev);
            //if (t == rev)
            //    Console.WriteLine("palindrome");
            //else
            //    Console.WriteLine("Not a Palindrome");

            for (int i = p; i <= p2; i++)
            {
                int t = i, rev = 0;
                while (t > 0)
                {
                    int r = t % 10;
                    rev = rev * 10 + r;
                    t /= 10;
                }

                if (i == rev)
                    Console.Write(i + " ");
            }

        }
    }
}
