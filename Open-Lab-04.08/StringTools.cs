using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> l = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                    l.Add(strings[i]);


            }
            return l.ToArray();
        }
    }
}