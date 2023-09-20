using System.Text.RegularExpressions;

namespace regex;
class Reg
{
    //Write a C# Sharp program to validate a password of length 7 to 16 characters with the following guidelines:
    //• Length between 7 and 16 characters.
    //• At least one lowercase letter(a-z).
    //• At least one uppercase letter(A-Z).
    //• At least one digit(0-9).
    //• Supported special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .

    static void Main(string[] args)
    {
        Console.Write("Enter Password in Validator : ");
        var password = Console.ReadLine();

        Console.WriteLine($"Your Password :{password} - validation : {ValidatorRegex(password)} ");

    }

    public static bool ValidatorRegex(string text)
    {
        bool result = (text.Length>=7 && text.Length<=16)
            && Regex.IsMatch(text,"[a-z]")
            && Regex.IsMatch(text,"[A-Z]")
            && Regex.IsMatch(text,"[0-9]")
            && !Regex.IsMatch(text, @"[^\dA-Za-z!-/:-@\[-_{-~]");

        return result;

    }

}