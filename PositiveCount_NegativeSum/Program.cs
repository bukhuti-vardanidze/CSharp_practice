namespace countOrSum;
class Program
{
    static void Main(string[] args)
    {
        int[] numbs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,35, -11, -12, -13, -14, -15 };

        SumOrCount(numbs);
        

    }

    public static void SumOrCount(int[] nums)
    {
        int number;
        int counter=0;
        int sum=0;

        for(int i = 0; i < nums.Length; i++)
        {
            number = nums[i];
            if(number <= 0 )
            {
                sum += number;
              
            }else 
            if( number >= 0 ) 
            { 
                counter++;
            }


        }

        Console.WriteLine($"Negative Numbers Sum = {sum}");
        Console.WriteLine($"Positive Numbers Quantity = {counter}");


    }

}