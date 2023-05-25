namespace EmployeeDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[]
            {
                new Employee{Id = 1, name = "Zahra", age = 26, gender = 'F', totalSale = 400000m},
                new Employee{Id = 2, name = "Mohammed",age = 40, gender = 'M', totalSale = 600000m},
                new Employee{Id = 3, name = "Mahmood", age = 24, gender = 'M', totalSale = 700000m},
                new Employee{Id = 4, name = "Sara", age = 34, gender = 'F', totalSale = 20000m},
                new Employee{Id = 5, name = "Arwa", age = 55, gender = 'F', totalSale = 50000m},

                new Employee{Id = 6, name = "Ali",age = 21, gender = 'M', totalSale = 900000m},
                new Employee{Id = 7, name = "Issa", age = 23, gender = 'M', totalSale = 70000m},
                new Employee{Id = 8, name = "Faisal", age = 20, gender = 'M', totalSale = 20000m},
                new Employee{Id = 9, name = "Abdullah", age = 22, gender = 'M', totalSale = 40000m},
            };

            Reports reports = new Reports();

            reports.ProcessEmployee(emps,"sale more than 60k and age greater than 25", (emp) => emp.totalSale >= 60000m && emp.age>25);
            reports.ProcessEmployee(emps, "sale between 30k & 60k and age greater than 25", (emp) => emp.totalSale >= 30000m && emp.totalSale <= 60000m && emp.age > 25);
            reports.ProcessEmployee(emps, "sale less than 30k and age greater than 25", (emp) => emp.totalSale < 30000m && emp.age > 25);


            reports.ProcessEmployee(emps, "sale more than 60k and age less than 25", (emp) => emp.totalSale >= 60000m && emp.age < 25);
            reports.ProcessEmployee(emps, "sale between 30k & 60k and age less than 25", (emp) => emp.totalSale >= 30000m && emp.totalSale <= 60000m && emp.age < 25);
            reports.ProcessEmployee(emps, "sale less than 30k and age less than 25", (emp) => emp.totalSale < 30000m && emp.age < 25);




        }
    }
}