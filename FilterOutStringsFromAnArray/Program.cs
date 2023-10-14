namespace filter;
class Program
{
    static void Main(string[] args)
    {
        object[] mixedList =  { 1, 2, "a", "b" };
     
        Console.WriteLine($"Integers in Array : {ArrayFilter(mixedList)}");


    }

    static object[] ArrayFilter(object[] array)
    {
        List<object> filteredList = new List<object>();
        int[] numbsArr;

        foreach(var item in array)
        {
            if(item is int && (int) item >= 0)
            {
                filteredList.Add(item);
            }

        }


      return filteredList.ToArray();

    }

}