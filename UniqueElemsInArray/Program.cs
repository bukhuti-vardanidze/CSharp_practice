using System.ComponentModel;
using System.Xml.Linq;
using System;

namespace arr;
 class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 5;
        arr[2] = 7;
        arr[3] = 1;
        arr[4] = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            bool isUnique = true;

            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j && arr[i] == arr[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                Console.WriteLine(arr[i]);
            }
        }
        






    }
}