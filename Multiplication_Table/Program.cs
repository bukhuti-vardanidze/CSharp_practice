using static System.Net.Mime.MediaTypeNames;

namespace multiplication_table
{
    public class table
    {
        public static void Main(String[] args) 
        {
            int result=0;
            Console.Write("Enter Number From 0 to 10 : ");
            var number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine(result);
            }

            Console.WriteLine("Done");


            // Write a C# Sharp program that prints the multiplication table of a number as input.
            
        }
    }
}
