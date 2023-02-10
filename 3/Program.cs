using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            List<int> sumList = new List<int>();
            sumList.Add(1);
            while (sumList.Count < n)
            {
                if(sumList.Count < k)
                {
                    for (int s1 = 0; s1 < sumList.Count; s1++)
                    {
                        sum = sum + sumList[s1];
                    }
                    sumList.Add(sum);
                    sum = 0;
                }
                else
                {
                    for (int s1 = sumList.Count - k; s1 < sumList.Count; s1++)
                    {
                        sum = sum + sumList[s1];
                    }
                    sumList.Add(sum);
                    sum = 0;
                }
            }
            Console.WriteLine(string.Join(" ", sumList));
        }
    }
}
