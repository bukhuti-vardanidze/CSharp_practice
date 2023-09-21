namespace emp;
public class Person
{
    public class Employee {
      public string Name { get; set; }
      public DateOfBith DateOfB { get; set; }
    }

    public class DateOfBith
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }

    static void Main(string[] args)
    {
        var emplCuant = 2;
        int day, month, year;
        Employee employee = new Employee();
        
      

        for (int i = 0; i < emplCuant; i++)
        {
            Console.Write("Enter Name : ");
            var name = Console.ReadLine();
            employee.Name = name;

            Console.Write("Enter Bith Day : ");
             day = Convert.ToInt32(Console.ReadLine());
            employee.DateOfB.Day = day;

            Console.Write("Enter Bith Month : ");
             month = Convert.ToInt32(Console.ReadLine());
            employee.DateOfB.Month = month;


            Console.Write("Enter Bith Year : ");
             year = Convert.ToInt32(Console.ReadLine());
            employee.DateOfB.Year = year;


        }

    }
}