namespace checker;
public class characterChecker
{
 public static void Main(string[] args)
    {
        Console.Write("enter text : ");
        var text = Console.ReadLine();
        Console.WriteLine(checker(text));

    }

    public static bool checker(string text)
    {
        var result = false;
        
       if (text.StartsWith("c#"))
        {
            result = true;
        } else
        {
            result= false;
        }

       return result;
    }

}
