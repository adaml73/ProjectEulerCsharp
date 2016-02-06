using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intMax = 1000; 
            int intCounter = 0; 
            int intAnswer = 0; 
            
           
            
            while (intCounter < intMax)
            {
                if ((intCounter % 3 == 0) || (intCounter % 5 == 0) == true)
                {
                    Console.WriteLine(intCounter);
                    intAnswer = intAnswer + intCounter;
                    ++intCounter;
                }
                else
                {
                    ++intCounter;
                }

              
               
            }

            Console.WriteLine(intAnswer);
            Console.ReadLine();
        }
    }
}
