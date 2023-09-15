namespace TriangleWithAnAsterisk;
public class Program
{
    //1 - Write a program in C# Sharp to display a right angle triangle with an asterisk.
    //2 - Write a program in C# Sharp to display a pattern like a right angle triangle with a number
    public static void Main(string[] args)
    {
       // asterisk();
        number();
    }

    public static void asterisk()
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

    public static void number()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("enter Row Number : ");
        var rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.Write("\n");
        }

    }
}