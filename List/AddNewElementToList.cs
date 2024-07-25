using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1.List
{
    internal class AddNewElementToList
    {
        static void Main()
        {
            var list = new List<int>();
            var watch = new Stopwatch();//засекаем время выполнения кода
            watch.Start();

            for (int i = 0; i < 10000; i++)
            {
                list.Insert(0, i);//вставляем элемент на 0 индекс
            }
            watch.Stop();//останавливаем
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
