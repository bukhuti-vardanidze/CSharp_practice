using System.ComponentModel;
using System.Numerics;
using System.Text.RegularExpressions;

namespace email;
class Program
{

    //Create a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

    //The string must contain an @ character.
    //The string must contain a.character.
    //The @ must have at least one character in front of it.
    //e.g. "e@edabit.com" is valid while "@edabit.com" is invalid.
    //The.and the @ must be in the appropriate places.
    //e.g. "hello.email@com" is invalid while "john.smith@email.com" is valid.

    static void Main(string[] args)
    {
        Console.WriteLine(ValidateEmail("e@edabit.com")); 
        Console.WriteLine(ValidateEmail("@edabit.com"));  
        Console.WriteLine(ValidateEmail("hello.email@com")); 
        Console.WriteLine(ValidateEmail("john.smith@email.com"));  

    }

    public static bool ValidateEmail(string email)
    {    
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        return Regex.IsMatch(email, pattern);
    }
} 
