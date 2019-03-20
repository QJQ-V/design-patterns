using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name,string dept,int salary) {
            this.name = name;
            this.dept = name;
            this.salary = salary;
            subordinates = new List<Employee>();
        }

        public void add(Employee e)
        {
            subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }

        public String toString()
        {
            return ("Employee :[ Name : " + name
            + ", dept : " + dept + ", salary :"
            + salary + " ]");
        }
    }
}
