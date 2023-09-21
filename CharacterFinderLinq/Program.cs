namespace linq;
class textLinq
{
    static void Main(string[] args)
    {
        string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        Console.Write("\nLINQ : Find the string which starts and ends with specific characters : ");
        Console.Write("\n-----------------------------------------------------------------------\n");
        Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

        Console.Write("\nInput starting character for the string : ");
        var ch = Convert.ToChar(Console.ReadLine());
        
        Console.Write("\nInput ending character for the string : ");
        var ch1 = Convert.ToChar(Console.ReadLine());

        var text = from city in cities
                   where city.StartsWith(ch) && city.EndsWith(ch1)
                   select city;

        foreach (var city in text)
        {
            Console.Write(city);
        }
       



    }

}