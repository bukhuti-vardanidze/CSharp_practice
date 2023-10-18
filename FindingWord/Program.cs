namespace word;
class Program
{
    static void Main(string[] args)
    {
        string text = "sdlfksa aye text jwefhbc texjbamdas0";
        FindWord(text);

    }

    static void FindWord(string text)
    {
        string word = "text";

        if (text.Contains(word))
        {
            Console.WriteLine($"text : {text}  contains word : {word}" );
        } else 
        {
            Console.WriteLine($"Can't found word : {word} in the text {text}");
        }
    }
}