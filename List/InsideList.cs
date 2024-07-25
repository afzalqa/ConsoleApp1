using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.List
{
    public class InsideList
    {
        public static void HowWorkListInside()
        {
            var list = new List<int>();

            //100 элементов последовательно добавляем в List
            //после чего выводим количество элементов и емкость
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
                Console.WriteLine(list.Count + "/t" + list.Capacity);
            }
        }
    }
    //list содержит ссылки на массив, при заполнении текущего, он создает новый 
    //и копирует туда данные увеличивая его объем
}
