using System.Runtime.Serialization;

namespace largestNum;
public class lasrgestVaule
{

    // Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive.
    // Return 0 if neither is in that range.
    public static void Main(string[] args)
    {
        Console.WriteLine(checker(10,24));
        Console.WriteLine(checker(28,24));
        Console.WriteLine(checker(20,30));
    }

    public static int checker(int a, int b)
    {
        var result = 0;
        var range1 = 20;
        var range2 = 30;
        if((a >= range1 && a <= range2) && (b >= range1 && b <= range2 ) ) 
        {
           result = Math.Max(a, b);
        } else
        {
            result = 0;
        }

        return result;

    }
}