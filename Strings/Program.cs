using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Supreme Leader of DPRK";
            int antal_key = name.Length;
          
            // Console.WriteLine("Der er {0} tegn i variablen\n", antal_key);

            Console.Write("Our Country's ruling father : {0}\n", name.Substring(0,22));
            
            Console.Write(""); Console.ReadKey();
        }
    }
}