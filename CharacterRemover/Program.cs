using System.Text;

namespace characterRemover;
public class charRemover
{

    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter the position to remove (0-based index): ");
        int positionToRemove = int.Parse(Console.ReadLine());

        if (positionToRemove >= 0 && positionToRemove < inputString.Length)
        {
            StringBuilder stringBuilder = new StringBuilder(inputString);
            stringBuilder.Remove(positionToRemove, 1); // Remove 1 character at the specified position
            string resultString = stringBuilder.ToString();

            Console.WriteLine("Resulting string: " + resultString);
        }
        else
        {
            Console.WriteLine("Invalid position. Position should be in the range 0..(string length - 1).");
        }
    }
}