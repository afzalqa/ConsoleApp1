using System;


namespace ConsoleApp1.List
{
    public class list
    {
        public static void listForeach()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Insert(0, 1); //insert позволяет вставить 1 на 0 индекс
            list.RemoveAt(0); //удаляет элемент на 0 индексе

            //Можем пройтись по листу foreach
            foreach (var e in list)
            {
                Console.WriteLine(e); // 0, 1, 2
            }

        }
    }
}
