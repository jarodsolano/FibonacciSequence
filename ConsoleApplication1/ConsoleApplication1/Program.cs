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
        public static Tuple<int, Array> bottomToTopFibaconni(int num1)
        {
            // Set desired number from user.
            int n = num1;
            // This is the smaller of the two sums.
            int n1 = 0;
            // This is the larger of the two sums.
            int n2 = 0;
            // This is a placeholder used when iterating to the next n1 and n2 number pair.
            int h1 = 0;
            // Create Array to prove results.
            int[] fibArray = new int[num1];
            // Begin for loop. (We will be starting at 1 for the first position.
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
                fibArray[i] = n2;
            }
            return Tuple.Create(n2, fibArray);
        }

        static void Main(string[] args)
        {
            int userInput1 = 5;
            Debug.WriteLine("Position number " + userInput1 + " equals " + bottomToTopFibaconni(userInput1));
        }


    }
}
