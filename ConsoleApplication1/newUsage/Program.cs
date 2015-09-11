using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newUsage
{

    class Employee
    {

        public string Name { get; set; }

        public Employee()
        {
            this.Name = "no name";
        }
        public Employee(string name)
        {
            this.Name = name;
        }
    }

    class EmployeeFactory<T> where T :new()
    {
        public T GetEmplyee()
        {
            return new T() ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeFactory<Employee> employeeFactory = new EmployeeFactory<Employee>();
            Employee e = employeeFactory.GetEmplyee();
            Console.WriteLine( e.Name) ;
            
        }
    }
}
