using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //part a
                int x = 20, y = 35;
                x = y++ + x++;
                y = ++y + ++x;
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.ReadLine();
          
            
          

            {
                //part b
                int a = 10, b = 15;
                x = a++;
                y = ++b;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.ReadLine();
            }
     
            {//part c
                int c = 10;
                c++;
                Console.WriteLine(c);
                Console.ReadLine();
            }
            {
                //part d
                int c = 10;
                Console.WriteLine(c++);
                Console.ReadLine();
            }
            {
                //part e
                int n = 10;
                int d = 0;
                d = n--;
                Console.WriteLine(d);
                Console.ReadLine();
            }
            {
                //part f
                int i = 5, j = 6, k = 7, n = 3;
                Console.WriteLine(i+j*k-k%n);
                Console.WriteLine(i / n);
                Console.ReadLine();

            }
            {
                //part g
                int g;
                float f;
                f = 3;
                //not working acurately
                //g = int(f);
                //Console.WriteLine(g);
                //Console.ReadLine();

                //part h
                int a = 6;
                Console.WriteLine(a);
                Console.ReadLine();

                a = a + 3;
                Console.WriteLine(a);
                Console.ReadLine();

                a = a- 5;
                Console.WriteLine(a);
                Console.ReadLine();

                a++;
               Console.WriteLine(a);
                Console.ReadLine();

            }

        }
    }
}
