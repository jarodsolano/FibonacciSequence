using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        public static int bottomToTopFibaconni(int num1)
        {
            int n = num1;
            int n1 = 0;
            int n2 = 0;
            int h1 = 0;
            for (int i = 1; i <= n; i++)
            {   
                if (i == 1 || i == 2)
                {
                    n1 = 1;
                    n2 = 1;
                    Debug.WriteLine("n1: " + n1);
                    Debug.WriteLine("n2: " + n2);
                    Debug.WriteLine("i: " + i);
                } else
                {
                    h1 = n2;
                    n2 = n1 + n2;
                    n1 = h1;
                    Debug.WriteLine("n1: " + n1);
                    Debug.WriteLine("n2: " + n2);
                    Debug.WriteLine("i: " + i);
                }
            }
            return n2;
        }

        static void Main(string[] args)
        {
            int userInput1 = 5;
            Debug.WriteLine("Position number " + userInput1 + " equals " + bottomToTopFibaconni(userInput1));
        }


    }
}
