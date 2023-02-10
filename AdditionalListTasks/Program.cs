using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalListTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string commandRaw = Console.ReadLine();
            List<string> commandList = new List<string>();
            while (commandRaw != "Odd" && commandRaw != "Even")
            {
                commandList = commandRaw.Split(' ').ToList();
                if (commandList[0] == "Delete")
                {
                    list.RemoveAll(item => item == int.Parse(commandList[1]));
                }
                else if (commandList[0] == "Insert") 
                {
                    list.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                }
                commandRaw = Console.ReadLine();
            }
            if(commandRaw == "Odd")
            {
                foreach(var number in list)
                {
                    if (number % 2 != 0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            else
            {
                foreach (var number in list)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}
