using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDelegate
{
    internal class Reports
    {
        public delegate bool SalesCondition(Employee employee);

        public void ProcessEmployee(Employee[] emp, string title, SalesCondition cond)
        {
            
            Console.WriteLine("\n"+ title);
            Console.WriteLine("----------------------------------------------------\n");
            foreach (Employee e in emp)
            {
                    if (cond(e))
                    {
                        Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Gender: {3}, Total Sale: {4}", e.Id, e.name, e.age, e.gender, e.totalSale);
                    }

            }
        }
    }
}
