﻿namespace rec;
class record 
{
    static int printNumber(int num, int num1)
    {
        if(num1<1)
        {
            return num;
        }

        num1--;
        Console.Write($" {0}",num);
        return printNumber(num+1, num1);


    }
    static void Main(string[] args)
    {
        Console.Write("enter number for recursion : ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        printNumber(1, number);
        Console.Write("\n\n");
    }
}