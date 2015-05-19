using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class MinMaxSumAverag
    {
        static void Main(string[] args)
        {
            {
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                float averageSum;
                int minNumber = int.MaxValue;
                int maxNumber = int.MinValue;

                for (int index = 0; index < num; index++)
                {
                    int newNumber = int.Parse(Console.ReadLine());
                    sum += newNumber;
                    if (newNumber > maxNumber)
                    {
                        maxNumber = newNumber;
                    }
                    if (newNumber < minNumber)
                    {
                        minNumber = newNumber;
                    }
                }

                averageSum = (float)sum / num;
                Console.WriteLine("min = {0}", minNumber);
                Console.WriteLine("max = {0}", maxNumber);
                Console.WriteLine("sum = {0}", sum);
                Console.WriteLine("avg = {0 :F2} ", averageSum);
            }
        }
    }
}
