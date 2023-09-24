using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Linq;

namespace algo;
class SortAlg
{
   

    static void Main(string[] args)
    {
        Random rand = new Random(100);

        Collection numbers = new Collection() ;
        for(int i =0; i < 10; i++)
        {
            numbers.Add((int)(rand.NextDouble()*100));
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

    public static void BubbleSort(Collection numbs)
    {

        var count = numbs.Count;

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if ((int)numbs[j] > (int)numbs[j + 1])
                {
                    // Swap numbs[j] and numbs[j + 1]
                    var temp = numbs[j];
                    //numbs[j] = numbs[j + 1];
                    //numbs[j + 1] = temp;
                }
            }
        }

    }
}