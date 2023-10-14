using quiz;

namespace qz;
class Program
{
    static void Main(string[] args)
    {

        Person[] persons = new Person[] {
         new Person("buta", 1500),
         new Person("buta", 1100),
         new Person("buta", 4300),
         new Person("buta", 2600),
          };

        Person.SortBySalary(persons);

        foreach(Person person in persons)
        {
                    
            Console.WriteLine(person);
        }

       
        

           

    }



}