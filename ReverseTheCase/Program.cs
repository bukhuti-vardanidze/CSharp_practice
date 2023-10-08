namespace reverse;
class Program
{
    //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
    static void Main(string[] args)
    {
       string s = ReverseCase("Happy Birthday");
       Console.WriteLine(s);

        s = ReverseCase("hEllO WolrD");
        Console.WriteLine(s);
    }

   public static string ReverseCase(string text)
    {
        //string[] txt = new string[text.Length];

        //for(int i = 0; i < txt.Length; i++)
        //{
        //    if 
        //}

        char[] chars = text.ToCharArray();
        for(int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }else if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }

        return new string(chars);

    }

}