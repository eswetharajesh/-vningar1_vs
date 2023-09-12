using övningar1;

internal class EmployeeRegistry
{
    

    private static void Main(string[] args)
    {
        int flag = 0;
        List<Employee> employees = new List<Employee>();    

        do
        {
            Console.WriteLine("Menu");

            Console.WriteLine("1) Register Employee");
            Console.WriteLine("2) View Registry");
            Console.WriteLine("3) Exit");

            Console.WriteLine("Please enter the option");
            flag = Convert.ToInt32(Console.ReadLine());
            if (flag == 1)
            {
                register();
            }
            else if (flag == 2)
            {
                printRegistry();
            }

        } while (flag !=3);


        void register()
        { 
            Employee employee = new Employee(); 
            Console.WriteLine("Please enter the employee name: ");
            employee.employeeName = Console.ReadLine();

            Console.WriteLine("Please enter the salary: ");
            employee.employeeSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Employee name is " + employee.employeeName + " and the salary is " + employee.employeeSalary + " registered");
            employees.Add(employee);
        }

        void printRegistry()
        {
            foreach(Employee e in employees){
                Console.WriteLine("The Employee name is " + e.employeeName + " and the salary is " + e.employeeSalary);
            }
           
        }
    }
}