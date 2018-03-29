using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sCheck = "";
            for (int intA = 2; intA <= 1000; intA++)
            {
                sCheck = "";
                for (int intB = 2; intB <= intA-1; intB++)
                {
                    if (intA % intB == 0) sCheck = "不是質數";
                }
                if (sCheck=="")
                {
                    Console.Write(intA + ",");
                }
                                   
            }
            Console.Read();
        }
    }
}
