using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<string> commandList = command.Split(' ').ToList();
            int rotationHelper;
            int sumHelper;
            List<int> listHelper = new List<int>();
            List<int> listClearer = new List<int>();
            while (command != "print")
            {
                commandList = command.Split(' ').ToList();
                if (commandList[0] == "add")
                {
                    numberList.Insert(int.Parse(commandList[1]), int.Parse(commandList[2]));
                }
                else if (commandList[0] == "addMany")
                {
                    for (int s1 = commandList.Count - 1; s1 >= 2; s1--)
                    {
                        numberList.Insert(int.Parse(commandList[1]), int.Parse(commandList[s1]));
                    }
                }
                else if (commandList[0] == "contains")
                {                   
                        Console.WriteLine(numberList.IndexOf(int.Parse(commandList[1])));                    
                }
                else if (commandList[0] == "remove")
                {
                    numberList.RemoveAt(int.Parse(commandList[1]));
                }
                else if (commandList[0] == "shift")
                {
                    for (int s2 = 0; s2 < int.Parse(commandList[1]); s2++)
                    {
                        rotationHelper = numberList[0];
                        numberList.RemoveAt(0);
                        numberList.Add(rotationHelper);
                    }
                }
                else if (commandList[0] == "sumPairs")
                {
                    if (numberList.Count % 2 == 0)
                    {
                        for (int s3 = 0; s3 < numberList.Count; s3 += 2) 
                        {
                            sumHelper = numberList[s3] + numberList[s3 + 1];
                            listHelper.Add(sumHelper);
                        }
                    }
                    else
                    {
                        for (int s4 = 0; s4 < numberList.Count - 1; s4 += 2)
                        {
                            sumHelper = numberList[s4] + numberList[s4 + 1];
                            listHelper.Add(sumHelper);
                        }
                    }
                    numberList = listHelper;
                    listHelper = listClearer;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numberList) + "]");
        }
    }
}
