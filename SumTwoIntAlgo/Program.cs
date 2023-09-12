namespace basicAlgo;
public class program
{
    public static void sumTwoInt(int x, int y)
    {
        var result = 0;
        if(x == y)
        {
            result = (x + y) * 3;
        } else
        {
            result = x + y;
        }

        Console.WriteLine(result);
    }

    public static void Main(string[] args)
    {
        sumTwoInt(1, 2);
        sumTwoInt(3, 3);
    }
}


