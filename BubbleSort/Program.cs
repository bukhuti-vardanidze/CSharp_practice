using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Linq;

namespace algo;
class SortAlg
{
   

    static void Main(string[] args)
    {
        Random rand = new Random(100);

        int[] numbers = new int[10];

        for(int i =0; i < 10; i++)
            {   
                numbers[i] = (int)(rand.NextDouble() * 100);
            }

        Console.WriteLine("Original numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        BubbleSort(numbers);

        Console.WriteLine("Sorted numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }



    }

    public static void BubbleSort(int[] numbs)
    {
        
        var count = numbs.Length;

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if ((int)numbs[j] > (int)numbs[j + 1])
                {
                    
                    var temp = numbs[j];
                    numbs[j] = numbs[j + 1];
                    numbs[j + 1] = temp;
                }
            }
        }

    }
}