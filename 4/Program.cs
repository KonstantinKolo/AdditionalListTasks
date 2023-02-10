using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int firstNum;
            int midNum;
            int lastNum;
            if(numberList.Count == 1)
            {
                Console.WriteLine(@"{ " + numberList[0] + @" }");
            }
            else if(numberList.Count % 2 == 0)
            {
                firstNum = numberList[numberList.Count / 2 - 1];
                lastNum = numberList[numberList.Count / 2];               
                Console.WriteLine(@"{ " + firstNum + ", " + lastNum + @" }");
            }
            else
            {
                firstNum = numberList[(numberList.Count -1 )/ 2 - 1];
                midNum = numberList[(numberList.Count - 1) / 2];
                lastNum = numberList[(numberList.Count - 1) / 2 + 1];
                Console.WriteLine(@"{ " + firstNum + ", " + midNum + ", "+ lastNum + @" }");
            }
        }
    }
}
