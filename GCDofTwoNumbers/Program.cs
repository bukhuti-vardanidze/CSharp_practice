namespace gcd;
class Program
{
    static void Main(string[] args)
    {
        int gcd =  GCDofTwoNumbers(8, 16);
        Console.WriteLine(  gcd);
    }

    public static int GCDofTwoNumbers(int a,int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }


}