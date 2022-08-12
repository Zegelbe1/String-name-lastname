using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            // Her defineres vores variables "name"
            string name = "Supreme Leader of DPRK";
            string lastname = "";
            
            // Her defineres 
            int antal_key = name.Length;

            // Console.WriteLine("Der er {0} tegn i variablen\n", antal_key);

            // Console.Write("Our Country's ruling father : {0}\n", name.Substring(0, 15));

            

            for (int pos = 0; name.Substring(pos, 1) != " "; pos = pos +1)
            {
            Console.Write(name.Substring(pos, 1));
            }


            int lastPos = name.Length - 14;

            for (int pos = name.Length-14; name.Substring(pos,1) != " "; pos = pos +1)
            {
                lastname = name.Substring(pos, 1) + lastname;
               

            }
            Thread.Sleep(500);
            Console.Write(" " + lastname);




            Console.Write(""); Console.ReadKey();



        }
    }
}