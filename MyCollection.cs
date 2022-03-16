using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    internal class MyCollection
    {
        List<Department> departmentList;
        List<Employee> employeeList;        

        public MyCollection()
        {
            try
            {
                departmentList = new List<Department>()
                {
                    new Department() { DepartmentID = 1, DepartmentName = ".NET"},
                    new Department() { DepartmentID = 2, DepartmentName = "React"},
                    new Department() { DepartmentID = 3, DepartmentName = "Node"},
                    new Department() { DepartmentID = 4, DepartmentName = "Laravel"},
                    new Department() { DepartmentID = 5, DepartmentName = "Front End"},
                };
             
                employeeList = new List<Employee>()
                {
                    new Employee() { EmployeeID = 1, EmployeeName = "Chaitanya", Department = departmentList.Find(dept => dept.DepartmentName.Contains(".NET"))},
                    new Employee() { EmployeeID = 2, EmployeeName = "Dhruvi",    Department = departmentList.Find(dept => dept.DepartmentName.Contains(".NET"))},
                    new Employee() { EmployeeID = 3, EmployeeName = "Vishal",    Department = departmentList.Find(dept => dept.DepartmentName.Contains("React"))},
                    new Employee() { EmployeeID = 4, EmployeeName = "Falguni",   Department = departmentList.Find(dept => dept.DepartmentName.Contains("React"))},
                    new Employee() { EmployeeID = 5, EmployeeName = "Aamir",     Department = departmentList.Find(dept => dept.DepartmentName.Contains("Laravel"))},
                    new Employee() { EmployeeID = 6, EmployeeName = "Nikunj",    Department = departmentList.Find(dept => dept.DepartmentName.Contains("laravel"))},
                    new Employee() { EmployeeID = 7, EmployeeName = "Jay",       Department = departmentList.Find(dept => dept.DepartmentName.Contains("React"))},
                    new Employee() { EmployeeID = 8, EmployeeName = "Aayush",    Department = departmentList.Find(dept => dept.DepartmentName.Contains(".NET"))},
                    new Employee() { EmployeeID = 9, EmployeeName = "Jay",      Department = departmentList.Find(dept => dept.DepartmentName.Contains("Front End"))},
                    new Employee() { EmployeeID = 10, EmployeeName = "karan",    Department = departmentList.Find(dept => dept.DepartmentName.Contains("Node"))},
                    new Employee() { EmployeeID = 11, EmployeeName = "Shubham",  Department = departmentList.Find(dept => dept.DepartmentName.Contains(".NET"))},
                };
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void GetAllEmployee()
        {
            try
            {                
                employeeList.ForEach(emp => Console.WriteLine(emp.ToString()));
                Console.WriteLine("Total Employee: " + employeeList.Count);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }           
        }

        public void ManageEmployee(Employee employee)
        {
            try
            {
                if (employee.EmployeeID == 0) //Insert
                {
                    employee.EmployeeID = new Random().Next(999);
                    employeeList.Add(employee);
                }
                else //Update
                {
                    Employee? emp = employeeList.Find(emp => emp.EmployeeID == employee.EmployeeID);
                    if (emp != null)
                    {
                        emp.EmployeeName = employee.EmployeeName;
                        emp.Department = employee.Department ?? emp.Department;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Employee not found!");
                    }
                }
            } catch (Exception ex)            
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            { 
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void DepartmentwiseEmployee(string departmentName)
        {
            try
            {
                employeeList.Where(emp => emp.Department?.DepartmentName == departmentName)
                    .ToList()
                    .ForEach(emp => Console.WriteLine(emp.ToString()));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                Employee? emp = employeeList.Find(emp => emp.EmployeeID == id);
                employeeList.Remove(emp);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void DeleteAllNullDepartment()
        {
            try
            {
                employeeList.RemoveAll(emp => emp.Department is null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void SortByName()
        {
            var employees = from emp in employeeList
                            orderby emp.EmployeeName, emp.Department?.DepartmentName
                            select emp;
            employees.ToList().ForEach(emp => Console.WriteLine(emp.ToString()));

            //employeeList.Sort((a, b) => a.EmployeeName.CompareTo(b.EmployeeName));                                
            //employeeList.ForEach(emp => Console.WriteLine(emp.ToString()));
        }

        public void OrderByDesc()
        {
            //var descEmployees = from emp in employeeList
            //                    orderby emp.EmployeeID descending
            //                    select emp;

            //descEmployees.ToList().ForEach(emp => Console.WriteLine(emp.ToString()));

            employeeList
                .OrderByDescending(emp => emp.Department?.DepartmentName)
                .ThenBy(emp => emp.EmployeeName)
                .ToList()
                .ForEach(emp => Console.WriteLine(emp.ToString()));
        }

        public void OrderBySpecificField(Func<Employee, object> func) //String field
        {
            //By Reflection
            //var type = typeof(Employee).GetProperty(field);

            //employeeList
            //   .OrderBy(emp => type?.GetValue(emp, null))
            //   .ToList()
            //   .ForEach(emp => Console.WriteLine(emp.ToString()));

            employeeList                
                .OrderBy(func)
                .ToList()
                .ForEach(emp => Console.WriteLine(emp.ToString()));
        }

        public void GroupByDepartment()
        {
            //var groupedResult = from emp in employeeList
            //                    group emp by emp.Department?.DepartmentName;

            var groupedResult = employeeList.GroupBy(emp => emp.Department?.DepartmentName);
            foreach (var department in groupedResult)
            {
                Console.WriteLine($"\nDeptartment: {department.Key}");
                foreach (Employee emp in department) Console.WriteLine(emp.ToString());
            }
        }

        public void JoinEmployeeWithDepartment()
        {
            //var join = from emp in employeeList
            //           join dept in departmentList
            //           on emp.Department?.DepartmentID equals dept.DepartmentID
            //           select new
            //           {
            //               EmployeeID = emp.EmployeeID,
            //               DepartmentName = dept.DepartmentName,
            //               EmployeeName = emp.EmployeeName,
            //           };

            var join = employeeList.Join(
                    departmentList,
                    emp => emp.Department?.DepartmentID,
                    dept => dept.DepartmentID,
                    (emp, dept) => new
                    {
                        EmployeeID = emp.EmployeeID,
                        DepartmentName = dept.DepartmentName,
                        EmployeeName = emp.EmployeeName,
                    });

            join.ToList().ForEach(emp => Console.WriteLine($"EmployeeID: {emp.EmployeeID}" +
                $", Department: {emp.DepartmentName}" +
                $", Name: {emp.EmployeeName}"));
        }

        public void GroupJoinEmployeeWithdepartment()
        {
            //var groupJoin = from dept in departmentList
            //                join emp in employeeList
            //                on dept.DepartmentID equals emp.Department?.DepartmentID
            //                into departmentWiseEmployee
            //                select new
            //                {
            //                    Employees = departmentWiseEmployee,
            //                    DepartmentName = dept.DepartmentName
            //                };

            var groupJoin = departmentList.GroupJoin(
                    employeeList,
                    dept => dept.DepartmentID,
                    emp => emp.Department?.DepartmentID,
                    (dept, empGroup) => new
                    {
                        Employees = empGroup,
                        DepartmentName = dept.DepartmentName
                    });

            foreach (var department in groupJoin)
            {
                Console.WriteLine($"\nDepartment: {department.DepartmentName}");
                foreach (var emp in department.Employees) Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}");
            }
        }

        public void SelectMethod()
        {
            var employeeName = employeeList.Select(emp => new
            {
                Name = emp.EmployeeName
            });

            employeeList
                .Where(emp => emp.Department.DepartmentName == ".NET")
                .Select(emp => new { 
                     emp.EmployeeID
                    ,emp.EmployeeName
                }).ToList().ForEach(emp => Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName}"));

            employeeName.ToList().ForEach(emp => Console.WriteLine(emp.Name));           
        }        

        public void MaxEmployeeID()
        {
            Console.WriteLine(employeeList.Max(emp => emp.EmployeeID));
        }

        public void DictionaryImplemetation()
        {
            string line = "Dictionary cannot include duplicate or null keys, whereas values can be duplicated or null.";
            Dictionary<string, int> dictWord = new Dictionary<string, int>();
            line.ToLower()
                .Replace(",", "")
                .Replace(".", "")
                .Split(" ").ToList().ForEach(
                word =>
                {
                    if (dictWord.ContainsKey(word)) dictWord[word]++;
                    else dictWord[word] = 1;
                });
            
            //foreach(KeyValuePair<string, int> kvp in dictWord)
            //    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            
            foreach (var word in dictWord)
                Console.WriteLine($"{word.Key} : {word.Value}");

            var sortedByValue = dictWord.OrderBy(word => word.Value).ToList();
            var sortedByValueDesc = dictWord.OrderByDescending(word => word.Value).ToList();            
        }
    }
}
