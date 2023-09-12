namespace celsiusConverter
{
    public class Converter
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Celsius : ");
            var celsius = Convert.ToDouble(Console.ReadLine());

            var kelvin = celsius + 273.15;
            Console.WriteLine($"Kelvin : {kelvin}K");

            var fahrenheit = celsius + (18 / 10) + 32;
            Console.WriteLine($"Fahrenheit : {fahrenheit}F");
        }
    }
}
