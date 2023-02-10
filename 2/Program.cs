using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commandList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int s1 = commandList[0]; s1 < numberList.Count; s1++)
            {
                numberList.RemoveAt(s1);
            }
            for (int s2 = commandList[1] - 1; s2 >= 0; s2--) 
            {
                numberList.RemoveAt(s2);              
            }
            if (numberList.Contains(commandList[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
