namespace linq;
class findNum
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var query = from num in numbers
                    where (num % 2) == 0
                    select num;

        foreach(var num in query)
        {
            Console.Write("Even numbers - " +$"{num} ");
        }
        Console.WriteLine("\n");
        var query2 = from numb in numbers
                     where (numb / 2) != 0
                     select numb;
        foreach(var numb in query2)
        {
            Console.Write("Odd numbers - " + $"{numb}");
        }

    }
}