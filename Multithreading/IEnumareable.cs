using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class Employee  
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double  Balance { get; set; }
    }
     class TestEmplotyee
    {
        //IEnumareable Emp = new IEnumareable();
        public static void Main()
        { 
        List<Employee> emp = new List<Employee>();

            emp.Add(new Employee { id = 10, Name = "sridhar", City = "bangalore", Balance = 50000.23 });
            emp.Add(new Employee { id = 11, Name = "siddu", City = "jamakhandi", Balance = 40000.23 });
            emp.Add(new Employee { id = 12, Name = "karthik", City = "gani", Balance = 5000.23 });
            emp.Add(new Employee { id = 13, Name = "shreya", City = "konnur ", Balance = 60000.23 });
            emp.Add(new Employee { id = 14, Name = "siddu", City = "bagalkot", Balance = 70000.23 });


            foreach (Employee employee in emp)
            {
                Console.WriteLine(employee.id +" "+ employee.Name+" "+ employee.City+" "+employee.Balance);
                
            }
            Console.Read();

        }

    }


}
