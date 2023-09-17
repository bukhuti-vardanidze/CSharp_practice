namespace arr;
public class array
{
    static void Main(string[] args)
    {
        int[] numArray = { 10, -58, 67, 12, 854, 8413, 125, 20, 51, 647 };
        foreach (int num in numArray)
        {
            
            if(num %2 == 0)
            {
                Console.WriteLine($"Odd Number - {num}");
            }
            else
            {
                Console.WriteLine($"Even Number - {num}");
            }
        }

        Thread.Sleep(2000);
        
        var max = numArray.Max();
        Console.WriteLine($"Max Number is - {max}");
        var min = numArray.Count();
        Console.WriteLine($"Min Number is - {min}");
    }
}