using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.List
{
    internal class StrangerAgain
    {

        public static string ApplyCommands(string[] commands)
        {
            StringBuilder text = new StringBuilder();

            foreach (string command in commands)
            {
                if (command.StartsWith("push"))
                {
                    int spaceIndex = command.IndexOf(' ');
                    if (spaceIndex != -1 && spaceIndex < command.Length - 1)
                    {
                        string toPush = command.Substring(spaceIndex + 1);
                        text.Append(toPush);
                    }
                }
                else if (command.StartsWith("pop"))
                {
                    int spaceIndex = command.IndexOf(' ');
                    if (spaceIndex != -1 && spaceIndex < command.Length - 1)
                    {
                        string numberStr = command.Substring(spaceIndex + 1);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int lengthToRemove = Math.Min(number, text.Length);
                            text.Remove(text.Length - lengthToRemove, lengthToRemove);
                        }
                    }
                }
            }

            return text.ToString();
        }

        public static void Stranger_Again()
        {
            string[] commands = new string[]
            {
            "push Привет! Это снова я! Пока!",
            "pop 5",
            "push Как твои успехи? Плохо?",
            "push qwertyuiop",
            "push 1234567890",
            "pop 26"
            };

            Console.WriteLine(ApplyCommands(commands));
        }
    }

}
