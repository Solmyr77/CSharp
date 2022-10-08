using System;
using System.Linq;
using System.Collections.Generic;

namespace CharacterFinder
{
    class Program
    {
        static void GetCharList(string text)
        {
            List<char> output_list = new List<char>();
            for (int i = 0; i < text.Length; i++) {
                output_list.Add(text[i]);
            }
            List<char> checking_list = new List<char>();
            for (int i = 0; i < output_list.Count; i++) {
                int count = output_list.Where(item => item == output_list[i]).Count();
                string current_char = output_list[i].ToString();
                if (current_char.ToString() == " ") {
                    current_char = "space";
                }
                if (checking_list.Contains(output_list[i])) {;}
                else {
                    Console.WriteLine($"{current_char}: {count}");
                }
                checking_list.Add(output_list[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy szöveget: ");
            string user_input = Console.ReadLine();
            GetCharList(user_input);
        }
    }
}
