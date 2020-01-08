using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class MainClass
    {
       
        public static string PalindromeCreator(string str)
        {
            List<string> removedfull = new List<string>();
            removedfull =(RemoveOneCharacter(str).Concat(RemoveTwoCharacter(str))).ToList();
            removedfull.Add(str);

            foreach (string item in removedfull)
            {
                if (Reverse(item) == item)
                {
                    return "the string palindrome";
                }
            }
                 return "the string not possible";

        }

        static void Main()
        {
                Console.WriteLine(PalindromeCreator(Console.ReadLine()));
            Console.ReadKey();
           
        }


        public static string Reverse(string str)
        {
            string reverseword = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseword += str.Substring(i, 1);
            }
            return reverseword;
        }
        public static List<string> RemoveOneCharacter(string str)
        {
            List<string> removedOne = new List<string>();
            if (str.Length>=4)
            {        
                for (int i = 0; i < str.Length; i++)
                {
                    removedOne.Add(str.Remove(i, 1));
                }
            }
           
            return removedOne;
        }
        public static List<string> RemoveTwoCharacter(string str)
        {
            List<string> removedTwo = new List<string>();
            if (str.Length>=5)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string strremove = str.Remove(i, 1);
                    for (int j = 0; j < strremove.Length; j++)
                    {
                        removedTwo.Add(strremove.Remove(j, 1));
                    }
                }             
            }
            return removedTwo;
        }
    }
}
