namespace NaturalNumbers;
public class program
{
    //Write a program in C# Sharp to display the n terms of even natural number and their sum.
    public static void Main(string[] args)
    {
        Console.Write("Enter Max Number : ");
        var num = Convert.ToInt32(Console.ReadLine());
        var result = 0;
        for(int i = 0; i < num; i++)
        {

            Console.WriteLine("Even Numbers : {0}",i*2);
            result += 2 * i;

            
        }
        Console.WriteLine(result);
    }
}
