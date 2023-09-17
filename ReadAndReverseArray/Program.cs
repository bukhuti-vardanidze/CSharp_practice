namespace Array;
public class Arr
{
    static void Main(string[] args)
    {
        //int[] numArr = { 2, 5, 7 };
        //foreach (int num in numArr)
        //{
        //    Console.Write(num + " ");
        //}
        
        Console.Write("Enter Number : ");
        var num = Convert.ToInt32(Console.ReadLine());

        int[] numberArray = new int[num];
        

        for(int i = 1; i< num; i++)
        {
            numberArray[i] = i;
        }

        foreach(int n in numberArray)
        {
            Console.Write($"Array - {n} ");
        }

        for (int j = num - 1; j >= 0; j--)
        {
            Console.WriteLine($"Reverse Array - {j} ");
        }
        numberArray.Reverse();
        Console.WriteLine(numberArray);

    }
}