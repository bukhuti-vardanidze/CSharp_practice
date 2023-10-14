using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class Person :IPerson
    {
        protected string fullName;
        public decimal salary;
        protected decimal bonuss;

   


        public Person(string FullName, decimal Salary)
        {
            fullName = FullName;
            salary = Salary;
            bonuss = SalaryBonus(Salary);
        }


        public decimal SalaryBonus(decimal sal)
        {
            decimal bonus = sal + ((sal / 100) * 3);

            return bonus;
        }

        public static void SortBySalary(Person[] people)
        {
            Array.Sort(people, (x, y) => x.salary.CompareTo(y.salary));
        }

        public override string ToString()
        {
            return $"{this.fullName} - Salary: {this.salary}, Bonus: {this.bonuss}";
        }



    }
}
