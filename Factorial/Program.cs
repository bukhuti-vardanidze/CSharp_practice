namespace factor;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factorial Calculator");
        Console.WriteLine("Enter Number : ");

        var number = Convert.ToInt32(Console.ReadLine());
        double result =1;

        if(number == 0)
        {
            result = 1 ;
        } else
        {
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
        }
        Console.WriteLine(result);
    }
}