using System;

namespace System.Runtime.CompilerServices
{
    public static class IsExternalInit
    {
        public record Employee(string Name, double Salary, double Bonus)
        {
            public Employee UpgradedSalary(double Updatedsalary) => this with { Salary = Updatedsalary };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            double Salary = double.Parse(Console.ReadLine());

            double Bonus;

            switch (Salary)
            {
                case <=50000 :
                    Bonus = 4500;
                    break;
                case <=75000:
                    Bonus = 6000;
                    break;
                case  90000:
                    Bonus = 8000;
                    break;
                default:
                    Bonus = 3000;
                    break;
            }

            Employee employee = new Employee(Name, Salary, Bonus);
            Console.WriteLine($"Employee {employee.Name} was receiving Salary of {employee.Salary} ");
            Console.WriteLine($"Employee {employee.Name} will be receiving Salary of {employee.Salary + Bonus}");
            Console.ReadLine();
        }
    }
}
