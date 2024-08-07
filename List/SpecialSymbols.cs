using System;

namespace ConsoleApp1.List
{
    internal class SpecialSymbols
    {
        static void Main()
        {
            for (int i = 10; i <= 100; i += 10)
            {
                Console.Write("\r" + i.ToString() + "%");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
