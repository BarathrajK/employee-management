using EmployeeManagement.Model;

namespace EmployeeManagement
{
    public class ManagementSystem
    {
        public ManagementSystem()
        {
            EmployeeManagementSystem();
        }
        public void EmployeeManagementSystem()
        {
            Console.WriteLine("--------------------------------------------EmployeeManagementSystem------------------------------------------------:");
            Console.WriteLine("Welcome To Employee....");
            List<EmployeeSystem> addEmployee = new List<EmployeeSystem>();
            try
            {
                while (true)
                {
                    Console.WriteLine("Actions;");
                    Console.WriteLine("1) Add New Contact");
                    Console.WriteLine("2) Update Employee");
                    Console.WriteLine("3) Delete Employee");
                    Console.WriteLine("4) Search Employee");
                    Console.WriteLine("5) for Quit");

                    Console.Write("Please Enter Your Choice :");
                    int actions;
                    if (!int.TryParse(Console.ReadLine(), out actions))
                    {
                        Console.WriteLine("Invalid Actions");
                        continue;
                    }
                    else if (actions <= 0 || actions >= 6)
                    {
                        Console.WriteLine("Please enter Valid actions.");
                    }
                    else if (actions <= 5)

                        switch (actions)
                        {
                            case 1:
                                Console.Write("FirstName :");
                                string? firstname = Console.ReadLine();
                                Console.Write("LastName :");
                                string? lastname = Console.ReadLine();
                                Console.Write("Age :");
                                int age;
                                if (!int.TryParse(Console.ReadLine(), out age))
                                {
                                    Console.WriteLine("Invalid age...");
                                    continue;
                                }
                                Console.Write("DateOfbirth :");
                                DateTime dateofbirth;
                                if (!DateTime.TryParse(Console.ReadLine(), out dateofbirth))
                                {
                                    Console.WriteLine("Invalid dateofbirth...");
                                    continue;
                                }
                                Console.Write("JoiningDate :");
                                DateTime joiningdate;
                                if (!DateTime.TryParse(Console.ReadLine(), out joiningdate))
                                {
                                    Console.WriteLine("Invalid joiningdate...");
                                    continue;
                                }
                                //int res = DateTime.Compare(dateofbirth, joiningdate);//dateofbirth and joiningdate to Datetime compare

                                //if (res < 0) { continue; } //since dateofbirth earlier than joiningdate 1

                                //else if (res > 0) { Console.WriteLine("since dateofbirth is later than joiningdate"); break; }

                                //else if (res == 0) { Console.WriteLine("Same datetime not Accepted"); break; }

                                if(dateofbirth.Date > joiningdate.Date)
                                {
                                    continue;
                                }

                                Console.Write("BasicSalary :");
                                int basicsalary;
                                if (!int.TryParse(Console.ReadLine(), out basicsalary))
                                {
                                    Console.WriteLine("Invaild Salary");
                                }

                                addEmployee.Add(new EmployeeSystem(firstname, lastname, age, dateofbirth, joiningdate, basicsalary));
                                Console.WriteLine("Employees...");
                                Console.WriteLine("ID".PadRight(3, ' ') + "FirstName".PadRight(10, ' ') + "LastName".PadRight(10, ' ') + "Age".PadRight(10, ' ') + "DateOfBirth".PadRight(25, ' ') + "JoiningDate".PadRight(25, ' ') + "BasicSalary".PadRight(25, ' '));
                                Console.WriteLine("------------------------------------------------------------------------------------------------");

                                foreach (var item in addEmployee)
                                {
                                    Console.WriteLine($"{(item.Id?.ToString()?.PadRight(3, ' '))}{(item.FirstName?.ToString()?.PadRight(10, ' '))}{(item.LastName?.ToString()?.PadRight(10, ' '))}{(item.Age?.ToString()?.PadRight(10, ' '))}{(item.DateOfBirth?.ToString()?.PadRight(25, ' '))}{(item.JoiningDate?.ToString()?.PadRight(25, ' '))}{(item.BasicSalary?.ToString()?.PadRight(25, ' '))}");
                                }
                                break;
                            case 2:
                                Console.Write("Enter Employee Id to Update :");
                                int update = int.Parse(Console.ReadLine());
                                EmployeeSystem updateEmployee = addEmployee.Find(emp => emp.Id == update);
                                if (updateEmployee == null)
                                {
                                    Console.WriteLine("Employee not found");
                                    break;

                                }
                                Console.Write("FirstName: ");
                                string? firstname1 = Console.ReadLine();
                                if (!string.IsNullOrEmpty(firstname1))
                                {
                                    updateEmployee.FirstName = firstname1;
                                }

                                Console.Write("LastName: ");
                                string? lastname1 = Console.ReadLine();
                                if (!string.IsNullOrEmpty(lastname1))
                                {
                                    updateEmployee.LastName = lastname1;
                                }

                                Console.Write("Age: ");
                                int Age1 = Convert.ToInt32(Console.ReadLine());
                                if (Age1 == null)
                                {
                                    Console.WriteLine("Age Not found");
                                }
                                else { updateEmployee.Age = Age1; }

                                Console.Write("DateOfBirth : ");
                                DateTime dateTime1;
                                if (DateTime.TryParse(Console.ReadLine(), out dateTime1))
                                {
                                    updateEmployee.DateOfBirth = dateTime1;
                                }
                                else if (!DateTime.TryParse(Console.ReadLine(), out dateTime1))
                                {
                                    Console.WriteLine("Invalid dateTime1");
                                    break;
                                }
                                Console.Write("JoiningDate : ");
                                DateTime joining;
                                if (DateTime.TryParse(Console.ReadLine(), out joining))
                                {
                                    updateEmployee.JoiningDate = joining;
                                }
                                else if (!DateTime.TryParse(Console.ReadLine(), out joining))
                                {
                                    Console.WriteLine("Invalid joiningdate");
                                    break;
                                }
                                if (dateTime1.Date > joining.Date)
                                {
                                    continue;
                                }
                                //int res1 = DateTime.Compare(dateTime1, joining);//equal  to res value in 0 different value in 1 to check..
                                //if (res1 < 0) ;//since dateofbirth earlier than joiningdate 1

                                //else if (res1 > 0) { Console.WriteLine("since dateofbirth is later than joiningdate"); break; }

                                //else if (res1 == 0) { Console.WriteLine("Same datetime not Accepted"); break; }
                                //else { continue; }
                                Console.Write("BasicSalary: ");
                                int salary = Convert.ToInt32(Console.ReadLine());
                                if (salary == null)
                                {
                                    Console.WriteLine("Salary not found");
                                }
                                else { updateEmployee.BasicSalary = salary; }

                                Console.WriteLine("Employees In Successfully Updated");
                                Console.WriteLine("ID".PadRight(3, ' ') + "FirstName".PadRight(10, ' ') + "LastName".PadRight(10, ' ') + "Age".PadRight(10, ' ') + "DateOfBirth".PadRight(25, ' ') + "JoiningDate".PadRight(25, ' ') + "BasicSalary".PadRight(25, ' '));
                                Console.WriteLine("------------------------------------------------------------------------------------------------");

                                foreach (var item in addEmployee)
                                {
                                    Console.WriteLine($"{(item.Id?.ToString()?.PadRight(3, ' '))}{(item.FirstName?.ToString()?.PadRight(10, ' '))}{(item.LastName?.ToString()?.PadRight(10, ' '))}{(item.Age?.ToString()?.PadRight(10, ' '))}{(item.DateOfBirth?.ToString()?.PadRight(25, ' '))}{(item.JoiningDate?.ToString()?.PadRight(25, ' '))}{(item.BasicSalary?.ToString()?.PadRight(25, ' '))}");
                                }
                                break;
                            case 3:
                                Console.Write("Enter Employee Id to Delete :");
                                int? delete = int.Parse(Console.ReadLine());
                                EmployeeSystem? deleteEmployee = addEmployee.Find(emp => emp.Id == delete);
                                if (deleteEmployee == null)
                                {
                                    Console.WriteLine("Employee Not found");
                                    return;
                                }
                                Console.Write($"Please Type yes to delete employee{deleteEmployee.Id}:Y Or N :");
                                string decisions = Console.ReadLine();
                                if (decisions == "Y")
                                {
                                    addEmployee.Remove(deleteEmployee);
                                    Console.WriteLine($"{deleteEmployee.Id} deleted");
                                }
                                else if (decisions == "N")
                                {
                                    Console.WriteLine("Wrong Decisions");
                                }
                                Console.WriteLine("Employees In Successfully Deleted..");
                                Console.WriteLine("ID".PadRight(3, ' ') + "FirstName".PadRight(10, ' ') + "LastName".PadRight(10, ' ') + "Age".PadRight(10, ' ') + "DateOfBirth".PadRight(25, ' ') + "JoiningDate".PadRight(25, ' ') + "BasicSalary".PadRight(25, ' '));
                                Console.WriteLine("------------------------------------------------------------------------------------------------");
                                foreach (var item in addEmployee)
                                {
                                    Console.WriteLine($"{(item.Id?.ToString()?.PadRight(3, ' '))}{(item.FirstName?.ToString()?.PadRight(10, ' '))}{(item.LastName?.ToString()?.PadRight(10, ' '))}{(item.Age?.ToString()?.PadRight(10, ' '))}{(item.DateOfBirth?.ToString()?.PadRight(25, ' '))}{(item.JoiningDate?.ToString()?.PadRight(25, ' '))}{(item.BasicSalary?.ToString()?.PadRight(25, ' '))}");
                                }
                                break;
                            case 4:
                                Console.Write("Enter Employee Char To Search :");
                                string? search = Console.ReadLine();
                                EmployeeSystem? searchEmployee = addEmployee.Find(emp => emp.FirstName == search);
                                if (searchEmployee == null)
                                {
                                    Console.WriteLine("Employee Not found");
                                }
                                else
                                {
                                    Console.WriteLine("ID".PadRight(3, ' ') + "FirstName".PadRight(10, ' ') + "LastName".PadRight(10, ' ') + "Age".PadRight(10, ' ') + "DateOfBirth".PadRight(25, ' ') + "JoiningDate".PadRight(25, ' ') + "BasicSalary".PadRight(25, ' '));
                                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                                    Console.WriteLine($"{(searchEmployee.Id?.ToString()?.PadRight(3, ' '))}{(searchEmployee.FirstName?.ToString()?.PadRight(10, ' '))}{(searchEmployee.LastName?.ToString()?.PadRight(10, ' '))}{(searchEmployee.Age?.ToString()?.PadRight(10, ' '))}{(searchEmployee.DateOfBirth?.ToString()?.PadRight(25, ' '))}{(searchEmployee.JoiningDate?.ToString()?.PadRight(25, ' '))}{(searchEmployee.BasicSalary?.ToString()?.PadRight(25, ' '))}");
                                }
                                break;
                            case 5:
                                Console.Write("Enter the Q to Quit..:");
                                string quit = Console.ReadLine();
                                if (quit == "Q")
                                {
                                    break;
                                }
                                return;
                            default:
                                break;
                        }
                }
            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message);
            }
        }
    }
}