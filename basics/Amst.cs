using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.basics
{
    internal class Amstr
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int t = n, c = 0,sum=0;
            while (t > 0)
            {
                c++;
                t /= 10;
            }
            t = n;
            while (n > 0)
            {
                int r = n % 10;
                int pow=(int)Math.Pow(r, c);
                sum+=pow;
                t /= 10;
            }
            if (t == sum)
                Console.WriteLine("Amstrong");
            else
                Console.WriteLine("Not an Amstrong");
        }
    }
}
