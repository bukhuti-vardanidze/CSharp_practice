using static System.Runtime.InteropServices.JavaScript.JSType;

namespace rec;
class record 
{
    static int printNumber(int num, int num1)
    {
        if(num1<num)
        {
            return num;
        }

        Console.Write($"{num} ");

        return printNumber(num+1, num1);

    }

    public static int Factorial(int num)
    {
        if(num <1)
        { 
            return 1;
        } else
        {
            return num * Factorial(num-1);
        }
         

    }

    public static int printReverseNumbers(int number, int bg)
    {
        if (number < bg)
        {
            return bg;
        }

        Console.Write($"{number} ");
        return printReverseNumbers(number - 1, bg);
    }

    static void Main(string[] args)
    {
        Console.Write("enter number for recursion : ");
        int number = Convert.ToInt32(Console.ReadLine());

         printNumber(1, number);

        // Console.WriteLine(Factorial(number));

        Console.WriteLine(printReverseNumbers(number,1));

        Console.Write("\n\n");
    }
}