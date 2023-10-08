using System.Collections;

namespace ArrayOfMultiple;
class Program
{
    //Create a function that takes two numbers as arguments (num, length)
    //and returns an array of multiples of num until the array length reaches length.

    static void Main(string[] args)
    {
       int[] arr =  ArrMult(8,5);
        Console.WriteLine(arr);

    }

    public static int[] ArrMult(int numb, int length)
    {
        int[] array = new int[length];

        for(int i = 0; i < length; i++)
        {
            array[i] = numb * (i +1) ;
            Console.WriteLine($"array of {i} num - {array[i]}");
        }

        return array;

    }

}
