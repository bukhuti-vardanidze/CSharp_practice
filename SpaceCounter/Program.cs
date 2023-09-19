namespace counter;
class program
{
    public static int SpaceCounter(string text)
    {
        byte space = 0;
        string text1;
        for(int i = 0; i < text.Length; i++)
        {
            text1 = text.Substring(i,1);
            if(text1 == " ")
            {
                space++;
            }

        }
        return space;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter text : ");
        var text = Console.ReadLine();
        var result =  SpaceCounter(text);

        Console.WriteLine($"text include : {result} space");

    }
}