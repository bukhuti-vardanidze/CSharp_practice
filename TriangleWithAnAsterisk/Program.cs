namespace TriangleWithAnAsterisk;
public class Program
{
    //Write a program in C# Sharp to display a right angle triangle with an asterisk.
    
    public static void Main(string[] args)
    {
        Console.Write("Enter row number : ");
        var row = Convert.ToInt32(Console.ReadLine());
        var result = "*";

        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= i; j++)
            {
              Console.Write("*");
              
            }
            Console.Write("\n");


        }
        
    }
}