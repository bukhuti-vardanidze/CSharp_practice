using System.Runtime.InteropServices;

namespace indx;
class Program
{
    //Create a function that takes a single string as argument
    //and returns an ordered array containing the indices of all capital letters in the string.
    static void Main(string[] args)
    {
        IndexOfCapitals("HgsA");
        IndexOfCapitals("eQuINoX");
        IndexOfCapitals("determine"); ;



    }

    public static void IndexOfCapitals(string text)
    {
        Console.WriteLine("text is " + text);
        char[] chars = text.ToCharArray();
        for(int i = 0; i<text.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
    
                Console.WriteLine($"Upper index is - {i}, character is {chars[i]}");
            } 
        }

        
    }
}
