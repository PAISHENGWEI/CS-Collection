using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 100;i++) 
            {
                string x = i.ToString().Replace("0", "D").Replace("3","A")
                    .Replace("5","B").Replace("9","C");
               
                 Console.WriteLine(x);
                

                
            }
                Console.ReadLine();

        }
    }
}
