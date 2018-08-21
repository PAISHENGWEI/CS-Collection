using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= 12;
            int y = 0;// 至少需幾個
            int x = 0;//換幾次
            for( n=0;n<=12;n++ )
            {

                if (n == 3)
                {
                    y = y + 3;
                    x = x + 1;
                    break;
                    
                }
                
            }
           int n1 = 12 - x - y;

            for (n = 0; n <= n1; n++)
            {
                if (n == 2)
                {
                    y = y + 2;
                    x = x + 1;
                    break;

                }

            }
            int n2 = 12 - x - y;
            
            for (n = 0; n <= n2; n++)
            {
                if (n == 2)
                {
                    y = y + 2;
                    x = x + 1;
                    break;

                }

            }
            int n3 = 12 - x - y;
            
            for (n = 0; n <= n3; n++)
            {
                if (n == 2)
                {
                    y = y + 2;
                    x = x + 0;
                    break;

                }

            }
            //Console.WriteLine(x+y);
            //Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();


           
        }
    }
}
