namespace ReturntheMiddleCharacter;
class Program
{
    static void Main(string[] args)
    {
        string md = GetMiddleText("test");
        Console.WriteLine(md);

        md = GetMiddleText("tests");
        Console.WriteLine(md);


    }

    static string GetMiddleText(string text)
    {
        int textLength = text.Length;

        if(textLength == 0)
        {
            return string.Empty;
        }

        if(textLength %2 == 1 )
        {
            int middleChar = textLength / 2;
            
            return text[middleChar].ToString();
        }  else {

            int middleChars = text.Length / 2 - 1; 
            return text.Substring(middleChars,2).ToString();

        }
        


    }

}
