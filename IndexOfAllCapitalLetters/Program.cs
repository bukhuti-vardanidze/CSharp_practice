﻿using System.Runtime.InteropServices;

namespace indx;
class Program
{
    //Create a function that takes a single string as argument
    //and returns an ordered array containing the indices of all capital letters in the string.
    static void Main(string[] args)
    {
         txt("HgsA");
      
    }

    public static void txt(string text)
    {
        char c;
        char[] chars = text.ToCharArray();
        for(int i = 0; i<text.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                Console.WriteLine($"Upper index is - {i}, character is {chars[i]}");
            }
        }

        
    }
}
