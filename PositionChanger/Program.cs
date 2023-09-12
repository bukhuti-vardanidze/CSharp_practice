namespace PositionChanger;
public class changer
{
    public static void Main(string[] args)
    {
        Console.Write("Enter text : ");
        var text =Console.ReadLine();

        string reverse = string.Empty;
        for(int i = text.Length-1; i>-1; i--)
            {
                reverse += text[i];
            }
        Console.WriteLine($"Reverse string :{reverse}");
    }
}
