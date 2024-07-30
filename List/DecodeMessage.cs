using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DecodeMessage
    {
        private static string Decode(string[] lines)
        {
            List<string> capitalizedWords = new List<string>();

            foreach (string line in lines)
            {
                string[] words = line.Split(" ");
                foreach (string word in words)
                {
                    if (!string.IsNullOrEmpty(word) && char.IsUpper(word[0]))
                    {
                        capitalizedWords.Add(word);
                    }
                }
            }
            capitalizedWords.Reverse();
            return string.Join(" ", capitalizedWords);
        }
        public static void Main(string[] args)
        {
            string[] lines = {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще",
                "чао"
            };
            string decode = Decode(lines);
            Console.WriteLine(decode);
        }
    }
}