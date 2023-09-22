namespace week;
class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Today;

        DateTime[] dates =  {  DateTime.Now, 
                                new DateTime(2008,09,02,10,15,00)};

        foreach(var dat in dates)
        {
            Console.WriteLine(dat.ToString());
        }

        Console.WriteLine(date.DayOfWeek);
       


    }
}